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
  public  class dars : dataAcsses_layer
    {
        public int id;
        public string name;
        public int vahed;
        public void add()
        {
            base.connect();
            string sql = "insert into dars(id,name,vahed)values('{0}',N'{1}','{2}'";
            sql = string.Format(sql, id, name, vahed);
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
            string sql = "select * from dars";
            DataTable dt = base.select(sql);
            base.disconnect();
            return dt;

        }


    }


    }

