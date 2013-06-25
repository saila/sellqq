using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GetQQ.pojo;
using GetQQ.util;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GetQQ.services
{
    class SellerServices
    {
        /// <summary>
        /// 保存卖家
        /// </summary>
        /// <param name="s"></param>
        public static int saveSeller(Seller s){
            MySqlConnection mysql = BaseDao.getMySqlCon();
            long tag = DateTime.Now.Ticks;
            string sql = "insert into seller values (null,'" +
                s.sWwNum+"','"+
                s.sName + "','" +
                s.sPhone + "','" +
                s.sQQ + "','" +
                s.typeName + "','" +
                s.inUrl + "',"+tag+")";
            MySqlCommand mySqlCommand = BaseDao.getSqlCommand(sql, mysql);
            mysql.Open();
            BaseDao.getInsert(mySqlCommand);
            //获取id
            sql = "select sid from seller where swwnum='" +
                s.sWwNum + "' and sName='" +
                s.sName + "' and sPhone='" +
                s.sPhone + "' and sQQ='" +
                s.sQQ + "' and typeName='" +
                s.typeName + "' and urlIn='" +
                s.inUrl+"' and tag=" +tag;
            string[] cols = new string[] { "sid" };
            mySqlCommand = BaseDao.getSqlCommand(sql, mysql);
            DataTable dt = BaseDao.getResultset(mySqlCommand, cols);
            string id =  dt.Rows[0][0].ToString();
            mysql.Close();
            return Convert.ToInt32(id);
        }
        /// <summary>
        /// 查找所有数据
        /// </summary>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static DataTable getAll(string[] cols)
        {
            MySqlConnection mysql = BaseDao.getMySqlCon();
            string sql = "select * from seller";
            MySqlCommand mySqlCommand = BaseDao.getSqlCommand(sql, mysql);
            mysql.Open();
            DataTable dt = BaseDao.getResultset(mySqlCommand, cols);
            mysql.Close();
            return dt;
        }

        /// <summary>
        /// 更新卖家信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static void update(Seller s) {
            MySqlConnection mysql = BaseDao.getMySqlCon();
            string sql = "update seller set swwnum='" +
                s.sWwNum + "',sName='" +
                s.sName + "',sPhone='" +
                s.sPhone + "',sQQ='" +
                s.sQQ + "',typeName='" +
                s.typeName + "',urlIn='" +
                s.inUrl + "' where sid=" + s.sid;
            MySqlCommand mySqlCommand = BaseDao.getSqlCommand(sql, mysql);
            mysql.Open();
            BaseDao.getUpdate(mySqlCommand);
            mysql.Close();
        }
    }
}
