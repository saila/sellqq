using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetQQ.pojo
{
    public class Seller
    {
        public int sid { get; set; }
        public String sWwNum { get; set; }
        public String sName { get; set; }
        public String sPhone { get; set; }
        public String sQQ { get; set; }
        public String typeName { get; set; }
        public string inUrl { get; set; }

        public Seller() { }
        public Seller(String sWwNum, String sName, String sPhone, String sQQ, String typeName,string inurl)
        {
            this.sWwNum = sWwNum;
            this.sName = sName;
            this.sPhone = sPhone;
            this.sQQ = sQQ;
            this.typeName = typeName;
            this.inUrl = inurl;
        }
    }
}
