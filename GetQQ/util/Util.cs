using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GetQQ.util
{
    class Util
    {

        public static DataSet ListToDataSet<T>(List<T> list)
        {
            if (list.Count == 0) return new DataSet();
            var properties = list[0].GetType().GetProperties();
            var cols = properties.Select(p => new DataColumn(p.Name));
            var dt = new DataTable();
            dt.Columns.AddRange(cols.ToArray());
            list.ForEach(x => dt.Rows.Add(properties.Select(p => p.GetValue(x,null)).ToArray()));
            return new DataSet { Tables = { dt } };
        }

        /// <summary>
        /// 获取网页url中的源码
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static WebBrowser getHtml(string url)
        {
            WebBrowser wb = new WebBrowser();
            wb.Navigate(new Uri(url));
            wb.ScriptErrorsSuppressed = true; //不显示ScriptErrors
            while (wb.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
            return wb;
        }

    }
}
