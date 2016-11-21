using System;
using System.Data;
using System.Data.SqlClient;

namespace DataExporter
{
    class testing
    {
        public static DataSet dgsql(String perintah)
        {
            DataSet ds = new DataSet();
            DataTable[] dt = new DataTable[10];
            SqlDataReader dr = null;
            Boolean err = false;
            String errMsg = "";
            using (SqlConnection conn = new SqlConnection("Server=localhost;Database=dataexporter;User Id=sa;Password=roni;"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(perintah, conn))
                    {

                        dr = cmd.ExecuteReader();
                        int i = 0;
                        while (true)
                        {
                            dt[i] = new DataTable();
                            dt[i].Load(dr);
                            ds.Tables.Add(dt[i]);
                            if(!dr.HasRows)
                            {
                                break;
                            }                           
                        }

                    }
                }
                catch (SqlException ex) // This will catch all SQL exceptions
                {
                    Console.WriteLine("SQL exception issue: " + ex.Message);
                    errMsg = ex.Message;
                    err = true;
                }
                catch (InvalidOperationException ex) // This will catch SqlConnection Exception
                {
                    Console.WriteLine("Connection Exception issue: " + ex.Message);
                    errMsg = ex.Message;
                    err = true;
                }
                catch (Exception ex) // This will catch every Exception
                {
                    Console.WriteLine("Exception Message: " + ex.Message); //Will catch all Exception and write the message of the Exception but I do not recommend this to use.
                    errMsg = ex.Message;
                    err = true;
                }
                if (err)
                {
                    DataTable dtr = new DataTable();
                    dtr.Columns.Add("ERROR");
                    dtr.Rows.Add(errMsg);
                    ds.Tables.Add(dtr);
                }
                conn.Close();
            }
            return ds;
        }
    }
}
