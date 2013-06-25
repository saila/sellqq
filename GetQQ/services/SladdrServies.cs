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
    class SladdrServies
    {
        /// <summary>
        /// 批量保存 二级地址
        /// </summary>
        public static void SaveSladdrList(List<Sladdr> sladrs,int sid)
        {
            MySqlConnection mysql = BaseDao.getMySqlCon();
            MessageBox.Show(sid +"-");
            mysql.Open();
            foreach (Sladdr sladr in sladrs)
            {
                string sql = "insert into sladdr values (null,'" +
                    sid + "','" +
                    sladr.title + "','" +
                    sladr.titleNote + "','" +
                    sladr.url + "','" +
                    sladr.note + "','" +
                    sladr.lrow + "','" +
                    sladr.rrow + "','" +
                    sladr.srcCode + "','" +
                    sladr.numTotal + "','" +
                    sladr.lastTime + "')";
                MySqlCommand mySqlCommand = BaseDao.getSqlCommand(sql, mysql);
                BaseDao.getInsert(mySqlCommand);
            }
            mysql.Close();
        }

        /// <summary>
        /// 查找所有数据
        /// </summary>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static DataTable getAll(string[] cols)
        {
            MySqlConnection mysql = BaseDao.getMySqlCon();
            string sql = "select * from Sladdr";
            MySqlCommand mySqlCommand = BaseDao.getSqlCommand(sql, mysql);
            mysql.Open();
            DataTable dt = BaseDao.getResultset(mySqlCommand, cols);
            mysql.Close();
            return dt;
        }

        /// <summary>
        /// 查找所有数据(只查固定的4个字段)
        /// </summary>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static DataTable getAllByFields(string[] cols,int sid)
        {
            MySqlConnection mysql = BaseDao.getMySqlCon();
            string sql = "select slid,title,titleNote,url,\"已保存\" as state from Sladdr where sid="+sid+";";
            MySqlCommand mySqlCommand = BaseDao.getSqlCommand(sql, mysql);
            mysql.Open();
            DataTable dt = BaseDao.getResultset(mySqlCommand, cols);
            mysql.Close();
            return dt;
        }
    }
}
