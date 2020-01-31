using System;
using System.Data;
using System.Data.SqlClient;
namespace System_Library_MVP_Cours_Mahmoud_Bakr.Logic.Services
{
    public class ClassDB
    {
        SqlConnection con;
        SqlCommand cmd;
        public string ErrorMsg;
        public int ErrorCode;

        public ClassDB()
        {
            string ModeStutas = Properties.Settings.Default.Mode;
            if (ModeStutas == "Sql Server  Authentication")
                con = new SqlConnection(@"Data Source=" + Properties.Settings.Default.ServerName + " , 1433" + " ;Initial Catalog= " + Properties.Settings.Default.Database + "; Persist Security Info=false;User ID=" + Properties.Settings.Default.Username + "; Password=" + Properties.Settings.Default.Password + "");
            else
                con = new SqlConnection(@"Data Source=" + Properties.Settings.Default.ServerName + " , 1433" + " ;Initial Catalog= " + Properties.Settings.Default.Database + "; Persist Security Info=True;");
        }

        public string RunDml(string stmt)
        {
            try
            {
                ;
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = stmt;

                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "ok";
            }
            catch (SqlException ex)
            {
                ErrorCode = ex.ErrorCode;
                return ErrorMsg = ex.Message;
            }
        }

        public DataTable RunQuery(string stmt)
        {
            try
            {
                ;
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = stmt;
                DataTable tbl = new DataTable();
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                tbl.Load(cmd.ExecuteReader());
                con.Close();
                return tbl;
            }
            catch (SqlException ex)
            {
                ErrorCode = ex.ErrorCode;
                ErrorMsg = ex.Message;
                return null;
            }
        }
    }
}
