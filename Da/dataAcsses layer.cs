using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Da;


namespace Da
{
    public class dataAcsses_layer
    {
        SqlConnection con;
        SqlCommand cmd;
        //SqlDataAdapter dap;
        DataTable dt;
        public dataAcsses_layer()
        {
            con = new SqlConnection();
            cmd = new SqlCommand("", con);
           // dap = new SqlDataAdapter();
            dt = new DataTable();
        }
        public void connect()
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=3lyer;Integrated Security=True";
            con.Open();
        }
        public void disconnect()
        {
            con.Close();
        }
        public DataTable select(string sql)
        {
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            //dap.Fill(dt);
            return dt;

        }
        public void docommand(string sql)
        {
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
    }

}



