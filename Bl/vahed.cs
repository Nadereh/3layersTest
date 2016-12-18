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
    class vahed : dataAcsses_layer
    {
        public int idvahed;
        public int codedaress;
        public string erahday;

        public int idostad;
        public int nomrh;
        public void add()
        {
            base.connect();
            string sql = "insert into vahed(idvahed,codedaress,erahday,idostad,nomrh)values('{0}','{1}',N'{2}','{3}','{4}";
            sql = string.Format(sql,idvahed, codedaress,erahday,idostad,nomrh);
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
            string sql = "select * from vahed";
            DataTable dt = base.select(sql);
            base.disconnect();
            return dt;
        }
    }
}
