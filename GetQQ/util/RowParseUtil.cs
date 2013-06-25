using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetQQ.util
{
    class RowParseUtil
    {

        public static string getNum(string instr, bool isQQNum)
        {
            char[] chars = instr.ToCharArray();
            string qq = "";
            //检测前面11位 --QQ最大为10位 --加上一位分隔符
            foreach (char ch in chars)
            {
                if (ch > 47 && ch < 59)
                {
                    //合法数字
                    qq += ch;
                }
                else break;
            }
            //是获取QQ号
            if (isQQNum)
            {
                if (qq.Length < 11 && qq.Length > 4)
                    return qq;
                else
                    return "-";
            }
            //不是
            else return qq;

        }

        public static string getQQprice(string inStr, string qqNum)
        {
            string price = "";
            int index = inStr.IndexOf("元");
            //号码分隔符 元之前至少一位
            if (index > qqNum.Length + 2)
            {
                //满足则截取 价格字符串
                string temp = inStr.Substring(0, index);
                char[] chars = temp.ToCharArray();
                for (int i = temp.Length; i > 0; i--)
                {
                    char ch = chars[i - 1];
                    if (ch > 47 && ch < 59)
                    {
                        //合法数字
                        price = ch + price;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (index > 0)
            {
                return "-1";
            }
            else
            {
                //字符串中没有元字处理流程
                string temp = inStr.Remove(0, qqNum.Length);//去掉QQ号
                bool tag = false;
                char[] chars = temp.ToCharArray();
                for (int i = temp.Length; i > 0; i--)
                {
                    char ch = chars[i - 1];
                    if (ch > 47 && ch < 59)
                    {
                        //合法数字
                        price = ch + price;
                        tag = true;
                    }
                    else if (!tag)
                    {
                        continue;
                    }
                    else break;
                }
            }
            return price;
        }

        public static string getQQLv(string inStr)
        {
            string lv = "";
            int index = inStr.IndexOf("级");
            if (index > 0)
            {
                //满足则截取 等级数字字符串
                string temp = inStr.Substring(0, index);
                char[] chars = temp.ToCharArray();
                for (int i = temp.Length; i > 0; i--)
                {
                    char ch = chars[i - 1];
                    if (ch > 47 && ch < 59)
                    {
                        //合法数字
                        lv = ch + lv;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return lv;
        }

        public static string getQQAge(string inStr)
        {
            string age = "";
            int index = inStr.IndexOf("年");
            if (index > 0)
            {
                //满足则截取 等级数字字符串
                string temp = inStr.Substring(0, index);
                char[] chars = temp.ToCharArray();
                for (int i = temp.Length; i > 0; i--)
                {
                    char ch = chars[i - 1];
                    if (ch > 47 && ch < 59)
                    {
                        //合法数字
                        age = ch + age;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                //判断是否有 Q龄: 字样
                index = inStr.IndexOf("Q龄:")+3;
                string temp = inStr.Substring(index);
                char[] chars = temp.ToCharArray();
                bool tag = false;
                for (int i = 0; i < temp.Length; i--)
                {
                    char ch = chars[i - 1];
                    if (ch > 47 && ch < 59)
                    {
                        //合法数字
                        age = ch + age;
                        tag = true;
                    }
                    else if (!tag)
                    {
                        continue;
                    }
                    else break;
                }
            }
            return age;
        }

        public static int getQQType(string instr)
        {
            //有群及连字的,=群连号,有群字的,=群号,没有群字的=QQ,有连字的=QQ连号
            int type = 1;
            if (instr.IndexOf("群") > -1) type += 2;
            if (instr.IndexOf("连") > -1) type += 4;
            if (instr.IndexOf("靓") > -1) type += 8;
            return type;
        }

        public static bool getIsFreeProtect(string instr)
        {
            return instr.IndexOf("送保") > -1;
        }
    }
}
