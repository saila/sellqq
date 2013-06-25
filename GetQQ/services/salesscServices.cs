using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace GetQQ.services
{
    class salesscServices
    {
        /// <summary>
        /// 查找所有数据
        /// </summary>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static DataTable getAll(string[] cols)
        {
            MySqlConnection mysql = BaseDao.getMySqlCon();
            string sql = "select * from salessc where valuetype='销售旺旺客服'";
            MySqlCommand mySqlCommand = BaseDao.getSqlCommand(sql, mysql);
            mysql.Open();
            DataTable dt = BaseDao.getResultset(mySqlCommand, cols);
            mysql.Close();
            return dt;
        }
    }
}
