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
    public class ostad : dataAcsses_layer
    {
        public int idostad;
        public string name;
        public string family;
        public string password;

        public int tell;
        public string adress;
        public void add()
        {
            base.connect();
            string sql = "insert into ostad(idostad,name,family,tell,adress,password)values('{0}',N'{1}',N'{2}','{3}',N'{4},N'{5}";
            sql = string.Format(sql, idostad, name, family, tell, adress, password);
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
            string sql = "select * from ostad";
            DataTable dt = base.select(sql);
            base.disconnect();
            return dt;
        }
        public bool login(string id, string pass)
        {
            base.connect();
            string sql = string.Format("select * from ostad where id = {0} and password = N'{1}'", id, pass);
            DataTable dt = base.select(sql);
            base.disconnect();
            return dt.Rows.Count > 0;
        }
    }
}
