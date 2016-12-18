using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Da;
using Bl;


namespace Bl
{
    public class daneshjo : dataAcsses_layer
    {
        public int id;
        public string name;
        public string family;
        public string adress;
        public string password;
        public int tell;
        public void add()
        {
            base.connect();
            string sql = "insert into daneshjo(name,family,adress,tell,password)values('{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}'";
            sql = string.Format(sql, id, name, family, adress, tell, password);
            base.docommand(sql);
            base.disconnect();

        }
        public void delete()
        {
            base.connect();
            base.connect();
            base.disconnect();

        }
        public DataTable select()
        {
            base.connect();
            string sql = "select * from daneshjo";
            DataTable dt = base.select(sql);
            base.disconnect();
            return dt;


        }
        public bool login(string id, string pass)
        {
            base.connect();
            string sql = string.Format("select * from daneshjo where id = {0} and password = N'{1}'", id, pass);
            DataTable dt = base.select(sql);
            base.disconnect();
            return dt.Rows.Count > 0;
        }
    }
}







