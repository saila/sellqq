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
    class ContextsServices
    {
        /// <summary>
        /// 批量保存 QQ数据
        /// </summary>
        public static void SaveSladdrList(List<Contexts> ctss)
        {
            MySqlConnection mysql = BaseDao.getMySqlCon();
            mysql.Open();
            foreach (Contexts cts in ctss)
            {
                //号码覆盖验证
                string selQQ = "SELECT cid,price FROM contexts where qqNum='" + cts.qqNum + "';";
                MySqlCommand mySqlCommand = BaseDao.getSqlCommand(selQQ, mysql);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                try
                {
                    if (reader.Read() && reader.HasRows)
                    {
                        int cid = reader.GetInt32(0);
                        double price = reader.GetDouble(1);
                        if (price - cts.price > 0)
                        {
                            //更新操作
                            cts.cid = cid;
                        }
                    }
                    else {
                        reader.Close();
                        //插入新记录
                        string sql = "insert into contexts values (null,'" +
                            cts.slid + "','" +
                            cts.srcRow + "','" +
                            cts.qqNum + "','" +
                            cts.price + "','" +
                            cts.qqLv + "','" +
                            cts.qqAge + "','" +
                            cts.qtid + "','" +
                            cts.radio + "','" +
                            ((cts.isFreeProtect == true) ? 1 : 0) + "','" +
                            cts.wwKehu + "','" +
                            cts.mima + "','" +
                            (cts.isConn + getConn(cts.qqNum,mysql)) + "')";
                        MySqlCommand mycmd = BaseDao.getSqlCommand(sql, mysql);
                        BaseDao.getInsert(mycmd);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("数据查询失败!\n" + e.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
            mysql.Close();
        }

        ///
        private static int getConn(long qqnum,MySqlConnection mysql) {
            int count  = 0;
            bool tag = false;
            long temp = qqnum;
            //号码覆盖验证
            do
            {
                tag = getCount(++temp, mysql);
                if(tag)count++;
            } while (tag);
            tag = false;
            temp = qqnum;
            do
            {
                tag = getCount(--temp, mysql);
                if (tag) count++;
            } while (tag);
            return count;
        }

        /// <summary>
        /// 更新卖家信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static void update(Contexts cts)
        {
            MySqlConnection mysql = BaseDao.getMySqlCon();
            string sql = "update contexts set srcRow='" +
                cts.srcRow + "',qqNum ='" +
                cts.qqNum + "',price ='" +
                cts.price + "',qqLv ='" +
                cts.qqLv + "',qqAge ='" +
                cts.qqAge + "',qtid ='" +
                cts.qtid + "',radio ='" +
                cts.radio + "',isFreeProtect ='" +
                ((cts.isFreeProtect==true)?1:0) + "',wwKehu ='" +
                cts.wwKehu + "',mima ='" +
                cts.mima + "',isConn ='" +
                (cts.isConn + getConn(cts.qqNum,mysql)) + "' where slid=" + cts.slid;
            MySqlCommand mySqlCommand = BaseDao.getSqlCommand(sql, mysql);
            mysql.Open();
            BaseDao.getUpdate(mySqlCommand);
            mysql.Close();
        }

        /// <summary>
        /// 更新卖家信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static void update(int slid,int connCount)
        {
            MySqlConnection mysql = BaseDao.getMySqlCon();
            string sql = "update contexts set isConn =" + connCount + " where slid=" + slid;
            MySqlCommand mySqlCommand = BaseDao.getSqlCommand(sql, mysql);
            mysql.Open();
            BaseDao.getUpdate(mySqlCommand);
            mysql.Close();
        }

        private static bool getCount(long newNum, MySqlConnection mysql)
        {
            bool tag = false;
            string selQQ = "SELECT cid,isconn FROM contexts where qqNum='" + newNum + "';";
            MySqlCommand mySqlCommand = BaseDao.getSqlCommand(selQQ, mysql);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            try
            {
                if (reader.Read() && reader.HasRows)
                {
                    update(reader.GetInt32(0),reader.GetInt32(1)+1);
                    tag = true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                reader.Close();
            }
            return tag;
        }
    }
}
