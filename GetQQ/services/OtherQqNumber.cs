using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetQQ.services
{
    public class OtherQqNumber
    {
        public string number;
        public OtherQqNumber(string number)
        {
            this.number = number;
        }
        /// <summary>
        /// qiege
        /// </summary>
        /// <param name="numberlong"></param>
        /// <returns></returns>
        private List<string> GetlistNumber(string numberlong)
        {
            string[] list = numberlong.Split('-');
            return list.ToList();
        }
        /// <summary>
        /// 多和少的号码
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<string> MoreAndless(List<string> data)
        {
            List<string> needdata = new List<string>();
            string morenumber = number + "?";
            foreach (var each in data)
            {

                if (FindQQsevice.singlenumber(each, morenumber))
                    needdata.Add(each);
                if (each.Contains(RomoveLast(number)) && each.Length == number.Length - 1)//少一个的
                    needdata.Add(each);
            }
            return needdata;
        }
        private string RomoveLast(string number)
        {
            return number.Remove(number.Length - 1);
        }
        /// <summary>
        /// 相差一个
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<string> ResembleNumber(List<string> data)
        {
            List<string> need = new List<string>();
            Char[] cha = number.ToCharArray();
            for (int i = 0; i < cha.Length; i++)
            {
                string number2 = replace(number, i);//替换表达式
                foreach (var each in data)
                {
                    if (FindQQsevice.singlenumber(each, number2) && each.Length == number.Length)
                        need.Add(each);
                }
            }
            return need;
        }
        private string replace(string a, int i)
        {
            string b = a.Substring(0, i);
            string c = a.Substring(i + 1, a.Length - i - 1);
            a = b + "?" + c;
            return a;
        }
    }
}
