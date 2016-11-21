USE [dataexporter]
GO
/****** Object:  Table [dbo].[appLog]    Script Date: 11/17/2016 10:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[appLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[identity] [varchar](255) NULL,
	[Modul] [varchar](255) NOT NULL,
	[Message] [varchar](4000) NOT NULL,
	[ip] [varchar](20) NULL,
	[sess] [int] NULL,
	[hostname] [varchar](255) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tGroup]    Script Date: 11/17/2016 10:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tGroup](
	[name] [varchar](255) NOT NULL,
	[notes] [varchar](1000) NULL,
	[tipe] [tinyint] NOT NULL,
	[isActive] [bit] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [nama_group] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[splitter]    Script Date: 11/17/2016 10:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[splitter]
(
@List nvarchar(2000),
@SplitOn nvarchar(5)
)
RETURNS @RtnValue table (Id int identity(1,1),hasil nvarchar(100))
AS
 BEGIN

  While(Charindex(@SplitOn,@List)>0)

   Begin

      Insert Into @RtnValue (hasil)
       Select hasil = ltrim(rtrim(Substring(@List,1,Charindex(@SplitOn,@List)-1))) 

  Set @List = Substring(@List,Charindex(@SplitOn,@List)+len(@SplitOn),len(@List))

  End

    Insert Into @RtnValue (hasil)

   Select hasil = ltrim(rtrim(@List))

  Return

END
GO
/****** Object:  UserDefinedFunction [dbo].[SplitStringRow]    Script Date: 11/17/2016 10:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[SplitStringRow]
(
    @str nvarchar(max), 
    @separator char(1)
)
returns table
AS
return (
with tokens(p, a, b) AS (
    select 
        cast(1 as bigint), 
        cast(1 as bigint), 
        charindex(@separator, @str)
    union all
    select
        p + 1, 
        b + 1, 
        charindex(@separator, @str, b + 1)
    from tokens
    where b > 0
)
select
    p-1 ItemIndex,
    substring(
        @str, 
        a, 
        case when b > 0 then b-a ELSE LEN(@str) end) 
    AS s
from tokens
);
GO
/****** Object:  UserDefinedFunction [dbo].[SplitIndex]    Script Date: 11/17/2016 10:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SplitIndex](@Delimiter varchar(20) = ' ', @Search varchar(max), @index int)
    RETURNS varchar(max)
    AS
    BEGIN
          DECLARE @ix int,
                      @pos int,
                    @rt varchar(max)

          DECLARE @tb TABLE (Val varchar(max), id int identity(1,1))

          SET @ix = 1
          SET @pos = 1


          WHILE @ix <= LEN(@search) + 1 BEGIN

                SET @ix = CHARINDEX(@Delimiter, @Search, @ix)

                IF @ix = 0
                      SET @ix = LEN(@Search)
                ELSE
                      SET @ix = @ix - 1

                INSERT INTO @tb
                SELECT SUBSTRING(@Search, @pos, @ix - @pos + 1)

                SET @ix = @ix + 2
                SET @pos = @ix + LEN(@Delimiter)-1
          END

          SELECT @Rt = Val FROM @Tb WHERE id = @index
          RETURN @Rt     
    END
GO
/****** Object:  StoredProcedure [dbo].[SearchDB]    Script Date: 11/17/2016 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchDB] @stringToFind VARCHAR(100), @skema sysname, @table sysname ,@kolom VARCHAR(500)='*',@awal INTEGER=0,@akhir INTEGER=25
AS

BEGIN TRY
	 DECLARE @jumlah INT
	 DECLARE @selisih INT = @akhir - @awal
	 DECLARE @sekarang INT = @akhir*1.0/(@akhir-@awal)
   DECLARE @sqlCommand varchar(max) = 'SELECT ROW_NUMBER() OVER (ORDER BY Id) AS Nomer,'+ @kolom +',COUNT(*) OVER() AS [Total_Rows] FROM [' + @skema + '].[' + @table + '] WHERE ' 
	   
   SELECT @sqlCommand = @sqlCommand + '[' + COLUMN_NAME + '] LIKE ''%' + @stringToFind + '%'' OR '
   FROM INFORMATION_SCHEMA.COLUMNS 
   WHERE TABLE_SCHEMA = @skema
   AND TABLE_NAME = @table 
   AND DATA_TYPE IN ('char','nchar','ntext','nvarchar','text','varchar')

	 SET @sqlCommand = left(@sqlCommand,len(@sqlCommand)-3)	 

	 if(@awal > 0)
	 BEGIN
		SELECT @sqlCommand = 'SELECT *,CEILING([Total_Rows]*1.0/'+CAST(@selisih as VARCHAR(15))+') as Total_page,FLOOR('+CAST(@sekarang as VARCHAR(15))+') AS Now_Page from ('+@sqlCommand + ') AS AX WHERE Nomer BETWEEN '+  CAST(@awal as VARCHAR(15)) + ' AND ' +  CAST(@akhir as VARCHAR(15))
	 END
	 ELSE
		SELECT @sqlCommand = 'SELECT *,1 as Total_page,FLOOR('+CAST(@sekarang as VARCHAR(15))+') AS Now_Page from ('+@sqlCommand + ') AS AX'
   
	 EXEC (@sqlCommand)
   PRINT @sqlCommand
END TRY

BEGIN CATCH 
   PRINT 'There was an error. Check to make sure object exists.'
   PRINT error_message()
END CATCH
GO
/****** Object:  Table [dbo].[tUser]    Script Date: 11/17/2016 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tUser](
	[username] [varchar](255) NOT NULL,
	[password] [varchar](500) NOT NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK__tUser__3213E83F7F60ED59] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tQuery]    Script Date: 11/17/2016 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tQuery](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[query] [varchar](max) NULL,
	[isActive] [bit] NOT NULL,
	[title] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [Nama_Query] UNIQUE NONCLUSTERED 
(
	[title] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPermission]    Script Date: 11/17/2016 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tPermission](
	[group] [varchar](255) NOT NULL,
	[modul] [varchar](255) NOT NULL,
	[permission] [tinyint] NULL,
 CONSTRAINT [PK__tPermiss__3213E83F164452B1] PRIMARY KEY CLUSTERED 
(
	[group] ASC,
	[modul] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tParameter]    Script Date: 11/17/2016 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tParameter](
	[parent_id] [int] NOT NULL,
	[jenis] [varchar](255) NOT NULL,
	[nilai] [varchar](255) NULL,
	[label] [varchar](255) NOT NULL,
	[nama] [varchar](255) NOT NULL,
 CONSTRAINT [PK__tParamet__3213E83F07F6335A] PRIMARY KEY CLUSTERED 
(
	[parent_id] ASC,
	[nama] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tUserGroup]    Script Date: 11/17/2016 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tUserGroup](
	[username] [varchar](255) NOT NULL,
	[group] [varchar](255) NOT NULL,
	[isActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC,
	[group] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[insertLog]    Script Date: 11/17/2016 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertLog]
	@ident VARCHAR(255),@modul VARCHAR(255),@messg VARCHAR(4000),@ip VARCHAR(20)=NULL,@hostn VARCHAR(255)=NULL,@sessi INT=NULL
AS
BEGIN
	DECLARE @lastid int
	INSERT appLog([Date],[identity],Modul,Message,sess,ip,hostname) VALUES (GETDATE(),@ident,@modul,@messg,@sessi,@ip,@hostn)
	SELECT @lastid = SCOPE_IDENTITY()
	SELECT @lastid
END
GO
/****** Object:  StoredProcedure [dbo].[getLog]    Script Date: 11/17/2016 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getLog]
	@cari VARCHAR(255)='',@awal INT=0,@akhir INT=25
AS
BEGIN
	WITH tbl1 AS
	(
		SELECT ROW_NUMBER() OVER (ORDER BY Id) AS Nomer,[Date],[identity],Modul,Message,ip,hostname,(SELECT COUNT(Id) from appLog) as total from appLog
	)
	SELECT * from tbl1 WHERE Nomer BETWEEN @awal AND @akhir AND [identity] like @cari
END
GO
/****** Object:  StoredProcedure [dbo].[getListQuery]    Script Date: 11/17/2016 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getListQuery]
	@name varchar(255)
AS
BEGIN
	SELECT c.id,c.title FROM tUserGroup as a 
	INNER JOIN tPermission as b ON a.username = @name AND b.[group] = a.[group] 
	INNER JOIN tQuery as c ON b.modul = c.title AND c.isActive = 1 
	GROUP BY c.id,c.title
END
GO
/****** Object:  StoredProcedure [dbo].[LogIn]    Script Date: 11/17/2016 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LogIn]
	@name varchar(255),@pass varchar(255),@ip VARCHAR(20),@hostn VARCHAR(255)
AS
BEGIN
	DECLARE @status VARCHAR(255) = 'Gagal'
	DECLARE @jmlhhasil INT
	DECLARE @logid INT
	SELECT c.name,c.tipe from tUser as a INNER JOIN tUserGroup as b ON a.username = b.username AND a.username = @name AND a.password like @pass INNER JOIN tGroup as c ON b.[group] = c.name
	Select @jmlhhasil = @@ROWCOUNT
	if(@jmlhhasil = 1)
		SELECT @status = 'Login Berhasil, Username = '+@name+' Pass = '+@pass
	ELSE
		SELECT @status = 'Login Gagal, Username = '+@name+' Pass = '+@pass

	EXEC insertLog @ident = @name,@modul='LogIn',@messg=@status,@ip=@ip,@hostn=@hostn
END
GO
/****** Object:  StoredProcedure [dbo].[insertUser]    Script Date: 11/17/2016 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertUser]
	@name varchar(255),@pass varchar(255),@perm TEXT
AS
BEGIN
DECLARE @namaid VARCHAR(255)
if(LEN(@pass)>1)
	BEGIN
		UPDATE tUser set password = @pass WHERE username = @name
		IF @@ROWCOUNT=0
			INSERT INTO tUser values(@name,@pass,'1')
	END
SELECT @namaid = SCOPE_IDENTITY()
DELETE from tUserGroup WHERE username = @name
if(DATALENGTH(@perm) > 1)
	BEGIN
		INSERT tUserGroup(username,"group",isActive) select @name,hasil,'1' from dbo.splitter(@perm,'|')
	END
END
GO
/****** Object:  StoredProcedure [dbo].[insertQuery]    Script Date: 11/17/2016 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertQuery]
	@query VARCHAR(MAX),@aktif BIT,@titel VARCHAR(255),@param VARCHAR(MAX),@id INT=NULL
AS
BEGIN
	DECLARE @lastid int
	DECLARE @namaid VARCHAR(255)
	if(@id IS NOT NULL)
		BEGIN
			UPDATE tQuery SET query = @query, isActive = @aktif, title = @titel WHERE id = @id
			SELECT @lastid = @id
		END
	ELSE
		BEGIN
			INSERT INTO tQuery(query,isActive,title) VALUES (@query,@aktif,@titel)
			SELECT @lastid = SCOPE_IDENTITY()
		END
	DELETE from tParameter WHERE parent_id = @lastid
	INSERT INTO tParameter SELECT @lastid, dbo.SplitIndex('|}',hasil,1), dbo.SplitIndex('|}',hasil,2), dbo.SplitIndex('|}',hasil,3), dbo.SplitIndex('|}',hasil,4) FROM dbo.splitter(@param,'{|')
END
GO
/****** Object:  StoredProcedure [dbo].[insertPerm]    Script Date: 11/17/2016 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertPerm]
	@id int=1,@name varchar(255),@cttn TEXT = '',@perm TEXT, @aktif bit = 1,@tipe int = 2
AS
BEGIN
DECLARE @lastid int
DECLARE @namaid VARCHAR(255)
UPDATE tGroup set name = @name, notes = @cttn, isActive = @aktif WHERE id = @id and name <> 'Administrator'
IF @@ROWCOUNT=0
   insert into tGroup(name,notes,tipe,isActive) values(@name,@cttn,'2',@aktif)
SELECT @lastid = SCOPE_IDENTITY()
if(@lastid is NULL)
		BEGIN
			SET @lastid = @id
		END
DELETE from tPermission WHERE "group" = @name
if(DATALENGTH(@perm) > 1)
	BEGIN
		INSERT tPermission("group",modul,"permission") select @name,hasil,'1' from dbo.splitter(@perm,'|')
	END
END
GO
/****** Object:  Default [DF__appLog__Date__46E78A0C]    Script Date: 11/17/2016 10:29:22 ******/
ALTER TABLE [dbo].[appLog] ADD  DEFAULT (getdate()) FOR [Date]
GO
/****** Object:  Default [DF__tGroup__tipe__1BFD2C07]    Script Date: 11/17/2016 10:29:22 ******/
ALTER TABLE [dbo].[tGroup] ADD  DEFAULT ((1)) FOR [tipe]
GO
/****** Object:  Default [DF__tGroup__isActive__1920BF5C]    Script Date: 11/17/2016 10:29:22 ******/
ALTER TABLE [dbo].[tGroup] ADD  CONSTRAINT [DF__tGroup__isActive__1920BF5C]  DEFAULT ((1)) FOR [isActive]
GO
/****** Object:  Default [DF__tUser__isActive__3E52440B]    Script Date: 11/17/2016 10:29:24 ******/
ALTER TABLE [dbo].[tUser] ADD  DEFAULT ((1)) FOR [isActive]
GO
/****** Object:  Default [DF__tQuery__isActive__0519C6AF]    Script Date: 11/17/2016 10:29:24 ******/
ALTER TABLE [dbo].[tQuery] ADD  DEFAULT ((0)) FOR [isActive]
GO
/****** Object:  ForeignKey [fk_group]    Script Date: 11/17/2016 10:29:24 ******/
ALTER TABLE [dbo].[tPermission]  WITH CHECK ADD  CONSTRAINT [fk_group] FOREIGN KEY([group])
REFERENCES [dbo].[tGroup] ([name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tPermission] CHECK CONSTRAINT [fk_group]
GO
/****** Object:  ForeignKey [fk_ugmt]    Script Date: 11/17/2016 10:29:24 ******/
ALTER TABLE [dbo].[tPermission]  WITH CHECK ADD  CONSTRAINT [fk_ugmt] FOREIGN KEY([modul])
REFERENCES [dbo].[tQuery] ([title])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tPermission] CHECK CONSTRAINT [fk_ugmt]
GO
/****** Object:  ForeignKey [FK__tParamete__paren__09DE7BCC]    Script Date: 11/17/2016 10:29:24 ******/
ALTER TABLE [dbo].[tParameter]  WITH CHECK ADD FOREIGN KEY([parent_id])
REFERENCES [dbo].[tQuery] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK_UGG]    Script Date: 11/17/2016 10:29:24 ******/
ALTER TABLE [dbo].[tUserGroup]  WITH CHECK ADD  CONSTRAINT [FK_UGG] FOREIGN KEY([group])
REFERENCES [dbo].[tGroup] ([name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tUserGroup] CHECK CONSTRAINT [FK_UGG]
GO
/****** Object:  ForeignKey [FK_UGU]    Script Date: 11/17/2016 10:29:24 ******/
ALTER TABLE [dbo].[tUserGroup]  WITH CHECK ADD  CONSTRAINT [FK_UGU] FOREIGN KEY([username])
REFERENCES [dbo].[tUser] ([username])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tUserGroup] CHECK CONSTRAINT [FK_UGU]
GO
