namespace DataExporter
{
    partial class DBConf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_sqltest = new System.Windows.Forms.Button();
            this.in_setdb = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_setdbsave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.in_setdbpass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.in_setdbuser = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.in_setdbport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.in_setdbserver = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_sqltest
            // 
            this.btn_sqltest.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sqltest.Location = new System.Drawing.Point(173, 166);
            this.btn_sqltest.Name = "btn_sqltest";
            this.btn_sqltest.Size = new System.Drawing.Size(75, 30);
            this.btn_sqltest.TabIndex = 7;
            this.btn_sqltest.Text = "Test";
            this.btn_sqltest.UseVisualStyleBackColor = true;
            this.btn_sqltest.Click += new System.EventHandler(this.btn_sqltest_Click);
            // 
            // in_setdb
            // 
            this.in_setdb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_setdb.Location = new System.Drawing.Point(92, 134);
            this.in_setdb.Name = "in_setdb";
            this.in_setdb.Size = new System.Drawing.Size(194, 26);
            this.in_setdb.TabIndex = 5;
            this.in_setdb.Text = "DB Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 134);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 20);
            this.label20.TabIndex = 25;
            this.label20.Text = "InitialDB :";
            // 
            // btn_setdbsave
            // 
            this.btn_setdbsave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setdbsave.Location = new System.Drawing.Point(92, 166);
            this.btn_setdbsave.Name = "btn_setdbsave";
            this.btn_setdbsave.Size = new System.Drawing.Size(75, 30);
            this.btn_setdbsave.TabIndex = 6;
            this.btn_setdbsave.Text = "Save";
            this.btn_setdbsave.UseVisualStyleBackColor = true;
            this.btn_setdbsave.Click += new System.EventHandler(this.btn_setdbsave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Password :";
            // 
            // in_setdbpass
            // 
            this.in_setdbpass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_setdbpass.Location = new System.Drawing.Point(93, 102);
            this.in_setdbpass.Name = "in_setdbpass";
            this.in_setdbpass.PasswordChar = '*';
            this.in_setdbpass.Size = new System.Drawing.Size(194, 26);
            this.in_setdbpass.TabIndex = 4;
            this.in_setdbpass.Text = "roni";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Username :";
            // 
            // in_setdbuser
            // 
            this.in_setdbuser.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_setdbuser.Location = new System.Drawing.Point(92, 70);
            this.in_setdbuser.Name = "in_setdbuser";
            this.in_setdbuser.Size = new System.Drawing.Size(194, 26);
            this.in_setdbuser.TabIndex = 3;
            this.in_setdbuser.Text = "sa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "PORT :";
            // 
            // in_setdbport
            // 
            this.in_setdbport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_setdbport.Location = new System.Drawing.Point(92, 38);
            this.in_setdbport.Name = "in_setdbport";
            this.in_setdbport.Size = new System.Drawing.Size(194, 26);
            this.in_setdbport.TabIndex = 2;
            this.in_setdbport.Text = "1433";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "SERVER :";
            // 
            // in_setdbserver
            // 
            this.in_setdbserver.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_setdbserver.Location = new System.Drawing.Point(92, 6);
            this.in_setdbserver.Name = "in_setdbserver";
            this.in_setdbserver.Size = new System.Drawing.Size(194, 26);
            this.in_setdbserver.TabIndex = 1;
            this.in_setdbserver.Text = "localhost";
            // 
            // DBConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 200);
            this.Controls.Add(this.btn_sqltest);
            this.Controls.Add(this.in_setdb);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btn_setdbsave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.in_setdbpass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.in_setdbuser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.in_setdbport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.in_setdbserver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBConf";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DBConf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sqltest;
        private System.Windows.Forms.TextBox in_setdb;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_setdbsave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox in_setdbpass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox in_setdbuser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox in_setdbport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox in_setdbserver;
    }
}