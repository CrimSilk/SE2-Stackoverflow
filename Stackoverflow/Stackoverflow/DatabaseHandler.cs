using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;

namespace Stackoverflow
{
    class DatabaseHandler
    {

        private OracleConnection con;
        private OracleCommand cmd;
        private OracleDataReader dr;

        public DatabaseHandler()
        {
            Connect();
            //Disconnect();
        }

        public void Connect()
        {
            con = new OracleConnection();
            //con.ConnectionString = "User ID=dbi317913; Password=I8zOKDgbJd; Data Source=192.168.15.50:1521/fhictora;";
            con.ConnectionString = "User Id=system; Password=Drowssap;Data Source=localhost/xe";
            con.Open();
            Console.WriteLine("CONNECTION SUCCESFULL");

        }

        public void Disconnect()
        {
            con.Close();
            con.Dispose();
        }

        private void ReadData(string sql)
        {
            try
            {
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                dr = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }

        public void WriteData(string sql)
        {
            try
            {
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }
        
    }
}