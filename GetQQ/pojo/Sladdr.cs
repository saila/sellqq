using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetQQ.pojo
{
    public class Sladdr
    {
        public int slid{get;set;}
        public int flid { get; set; }
        public String title { get; set; }
        public String titleNote { get; set; }
        public String url { get; set; }
        public String note { get; set; }
        public int lrow { get; set; }
        public int rrow { get; set; }
        public String srcCode { get; set; }
        public int numTotal { get; set; }
        public DateTime lastTime { get; set; }
        public String state { get; set; }

        public Sladdr() { }
        public Sladdr(String titleNote, String url) {
            this.title = titleNote;
            this.titleNote = titleNote;
            this.url = url;
            this.state = "未保存";
        }
    }
}
