using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GetQQ
{
    public static class spkt
    {
        /// <summary>
        /// 切割
        /// </summary>
        /// <param name="a"></param>
        public static List<string> Getlist(string text)
        {
            string c = Regex.Replace(text, @"[\n\r]", ",");
            c = c.TrimEnd(( char[])"\n\r" .ToCharArray());
            string f = c.Replace(",," , ",");
            string[] b = f.Split(',' );
            return b.ToList();
        }
    }
}
