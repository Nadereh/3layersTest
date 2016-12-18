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
    public class entekhabvahed : dataAcsses_layer
    {
        public int iddaneshjo;
        public string namedanshjo;
        public int idostad;
        public string nameostad;
        public int iddars;
        public string namedars;
        public float nomrh;
        public void add()
        {
            base.connect();
            string sql = "insert into entekhabvahed(iddaneshjo,idostad,iddars)values({0},{1},{2})";
            sql = string.Format(sql, iddaneshjo,idostad, iddars);
            base.docommand(sql);
            base.disconnect();
        }
        public void delete()
        {
            base.connect();
            string sql = "delete entekhabvahed where iddaneshjo = {0} and idostad = {1} and iddars = {2}";
            sql = string.Format(sql, iddaneshjo, idostad, iddars);
            base.docommand(sql);
            base.disconnect();
        }

        public void update()
        {
            base.connect();
            string sql = "update entekhabvahed set nomrh = {0} where iddaneshjo = {1} and idostad = {2} and iddars = {3}";
            sql = string.Format(sql,nomrh, iddaneshjo, idostad, iddars);
            base.docommand(sql);
            base.disconnect();
        }

        public DataTable selectbydaneshjo(int iddaneshjo)
        {
            base.connect();
            string sql = @"select idostad,ostad.name as nameostad,iddars,dars.name as namedars,nomrh from entekhabvahed
                           inner join ostad on idostad = ostad.id
                           inner join dars on iddars = dars.id
                           where iddaneshjo = " + iddaneshjo;
            DataTable dt = base.select(sql);
            base.disconnect();
            return dt;
        }

        public DataTable selectbyostad(int idostad)
        {
            base.connect();
            string sql = @"select iddaneshjo,daneshjo.name as namedaneshjo,iddars,dars.name as namedars,nomrh from entekhabvahed
                           inner join daneshjo on iddaneshjo = daneshjo.id
                           inner join dars on iddars = dars.id
                           where idostad = " + idostad;
            DataTable dt = base.select(sql);
            base.disconnect();
            return dt;
        }
    }
}

