using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GetQQ.pojo;
using GetQQ.util;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GetQQ.services
{
    public delegate void delegateFindprogress(string progress);
    public class FindQQsevice
    {
        public static event delegateFindprogress find;
        public static event delegateFindprogress findother;
        public static bool singlenumber(string QQsingleNumber, string check)
        {
            // string[] a = check.Split('?');//REGEXL ="/d*" "/"=/b  ^123\d*456$=/123?456/

            if (check.IndexOf("/") == 0 && check.LastIndexOf("/") == check.Length - 1) //all
            {
                check = check.Replace("/", "");
                check = "^" + check + "$";
            }
            else if (check.IndexOf("/") == 0 && check.LastIndexOf("/") != check.Length - 1)//before
            {
                check = check.Replace("/", "^");
            }
            else if (check.IndexOf("/") != 0 && check.LastIndexOf("/") == check.Length - 1) //after
            {
                check = check.Replace("/", "$");
            }
            string regx1 = check.Replace("?", @"\d*");
            Regex regex = new Regex(regx1);
            return regex.IsMatch(QQsingleNumber);

        }
        public static bool Lngnumber(string QQLongMuber, string check)
        {

            bool a = false;
            string[] qqlong = QQLongMuber.Split('-');
            check = check.Replace("=", "?-?");
            string[] checka = check.Split('-');
            int flag = 0;
            for (int i = 0; i < qqlong.Length - checka.Length + 1; i++)
            {

                for (int j = 0; j < checka.Length; j++)
                {
                    if (singlenumber(qqlong[i + j], checka[j]))
                    {
                        flag++;
                    }
                }
                if (flag == checka.Length)
                {
                    a = true;
                    break;
                }
            }
            return a;
        }
        public static DataTable Getfind(
            string length,
            string price,
            string level,
            string connum,
            string year,
            string month,
            string day,
            bool isfree,
            string regex,
            string numberclass
            ) 
        {
            long i = 0;
            DataTable table = new DataTable();
            table.Columns.Add("qqnum");
            table.Columns.Add("price");
            table.Columns.Add("qtid");
            table.Columns.Add("radio");
            table.Columns.Add("isFreeProtect");
            table.Columns.Add("mima");
            table.Columns.Add("level");
            table.Columns.Add("wwkehu");
            MySqlConnection mysql = BaseDao.getMySqlCon();
            mysql.Open();
            string sql = "SELECT * FROM contexts where qtid="+numberclass;
            MySqlCommand mySqlCommand = BaseDao.getSqlCommand(sql, mysql);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read() && reader.HasRows)
            {
                i++;
                if (check(length,price,level,connum,
                    year,month,day,isfree,readerdata(reader),regex
                    ))
                    {
                        DataRow dr = table.NewRow();
                        dr["qqnum"] = reader[3].ToString();
                        dr["price"]=reader[4].ToString();
                        dr["qtid"] = reader[7].ToString();
                        dr["radio"] = reader[9].ToString();
                        dr["isFreeProtect"] = reader[10].ToString();
                        dr["mima"] = reader[12].ToString();
                        dr["wwkehu"] = reader[11].ToString();
                        dr["level"]=reader[5].ToString();
                        table.Rows.Add(dr);
                    }
              find(i.ToString());
            }
            return table;
        }
        public static string[] readerdata(MySqlDataReader reader) 
        {
            string[] a=new string[reader.FieldCount];
            for (int i = 0; i < reader.FieldCount; i++) 
            {
                a[i] = reader[i].ToString();
            }
            return a;
        }
        /// <summary>
        /// 插入设置
        /// </summary>
        /// <param name="length"></param>
        /// <param name="price"></param>
        /// <param name="level"></param>
        /// <param name="Qage"></param>
        /// <param name="connnum"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static bool Sqldata(string length,string price,string level
            ,string Qage,string connnum,string year,string month,string day) 
        {
            delsql();
            MySqlConnection mysql = BaseDao.getMySqlCon();
            mysql.Open();
            string selQQ = "insert into Setdata values('"+
                            length + "','" +
                            level + "','" +
                            price + "','" +
                            Qage + "','" +
                            connnum + "','" +
                            year + "','" +
                            month + "','" +
                            day    
                       +"')";
            MySqlCommand mySqlCommand2 = BaseDao.getSqlCommand(selQQ, mysql);
            MySqlDataReader reader = mySqlCommand2.ExecuteReader();
            return true;
        }
        public static void delsql() 
        {
            string del = "DELETE FROM setdata";         
            MySqlConnection mysql = BaseDao.getMySqlCon();
            mysql.Open();
            MySqlCommand mySqlCommand = BaseDao.getSqlCommand(del, mysql);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
        }
        public static string[] GetSetData() 
        {
            string[] data=new string[8];
           MySqlConnection mysql = BaseDao.getMySqlCon();
            mysql.Open();
            string sql = "SELECT * FROM Setdata";
            MySqlCommand mySqlCommand = BaseDao.getSqlCommand(sql, mysql);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read() && reader.HasRows)
            {
                for (int i = 0; i < reader.FieldCount;i++ )
                    data[i] = reader[i].ToString();
            }
            return data;
        }
        public static bool check(
            string length,
            string price,
            string level,
            string connum,
            string year,
            string month,
            string day,
            bool isfree,
            string[] data,
            string regex
            ) 
        {
            string[] prciearry=Getsplt(price);
            string[] leng=Getsplt(length);
            if (singlenumber(data[3].ToString(), regex) &&
                data[3].ToString().Length <= Convert.ToInt32(leng[1]) &&
                data[3].ToString().Length >= Convert.ToInt32(leng[0]) &&
                Convert.ToDouble(data[4]) <= Convert.ToDouble(prciearry[1]) &&
                Convert.ToDouble(data[4]) >= Convert.ToDouble(prciearry[0]) &&
                Convert.ToInt32(data[5]) >= Convert.ToInt32(level) && //等级
                 Convert.ToDouble(data[12]) == Convert.ToDouble(connum) &&//连号
                  data[4].ToString().Contains(GetbrithDay(year, month, day)) &&//判断生日
                  data[9] == isfree.ToString())
                return true;
            else
                return false;
            

        }
        public static string GetbrithDay(string year, string month, string day) 
        {
            if (year == "" && month == "" && day == "") 
            {
                return "";
            }
            else
            {
                if (month.Length < 2)
                {
                    month = "0" + month;
                }
                if (day.Length < 2)
                    day = "0" + day;
            return year + month + day;
            }
           
        }
        public static string[] Getsplt(string each)
        {
            return each.Split('-');
        }
        /// <summary>
        /// 查找相邻的返回表
        /// </summary>
        /// <param name="length"></param>
        /// <param name="price"></param>
        /// <param name="level"></param>
        /// <param name="connum"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="isfree"></param>
        /// <param name="regex"></param>
        /// <param name="numberclass"></param>
        /// <returns></returns>
        public static DataTable Getfindotherqq(
    List<QQDetail> qq
    )
        {
            long i = 0;
            DataTable table = new DataTable();
            table.Columns.Add("qqnum");
            table.Columns.Add("price");
            table.Columns.Add("qtid");
            table.Columns.Add("radio");
            table.Columns.Add("isFreeProtect");
            table.Columns.Add("mima");
            table.Columns.Add("level");
            table.Columns.Add("wwkehu");
            foreach (var each in qq)
            {
                    DataRow dr = table.NewRow();
                    dr["qqnum"] = each.Qqnum;
                    dr["price"] = each.Prcie;
                    dr["qtid"] = each.Qtid;
                    dr["radio"] = each.Radio;
                    dr["isFreeProtect"] = each.IsFreeProtect;
                    dr["wwkehu"] = each.Wwkehu;
                    dr["level"] = each.Qqlevel;
                    table.Rows.Add(dr);
                
               
            }
            return table;
        }
        public static List<QQDetail> qqdata(
    string qq
    )
        {
            OtherQqNumber other = new OtherQqNumber(qq);
            List<string> data=new List<string>();
            List<QQDetail> qqlis = new List<QQDetail>();//总的
            long i = 0;
            MySqlConnection mysql = BaseDao.getMySqlCon();
            mysql.Open();
            string sql = "SELECT * FROM contexts" ;
            MySqlCommand mySqlCommand = BaseDao.getSqlCommand(sql, mysql);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read() && reader.HasRows)
            {
                QQDetail dd = new QQDetail();
                dd.Qqnum=reader[3].ToString();
                dd.Qqlevel=reader[5].ToString();
                dd.Prcie=reader[4].ToString();
                dd.Radio=reader[9].ToString();
                dd.Wwkehu=reader[11].ToString();
                dd.IsFreeProtect=reader[10].ToString();
                dd.Qtid=reader[7].ToString();
                qqlis.Add(dd);
                data.Add(reader[3].ToString());
            }
            List<string> number = other.MoreAndless(data);
            List<string> number2 = other.ResembleNumber(data);
            List<QQDetail> rightdata = new List<QQDetail>();//正确的
            number.AddRange(number2);
            string[] c = number.ToArray();
            HashSet<string> set = new HashSet<string>(number);//去除重复
            number.Clear();
            number = new List<string>(set);
            foreach (var each2 in number) 
            {
                i++;
                foreach (var each in qqlis) 
                {
                    if (each.Qqnum == each2 && each2!=qq)//删除自身
                        rightdata.Add(each);
                    findother(i.ToString());
                }
            }
            return rightdata;
        }
    }
}
