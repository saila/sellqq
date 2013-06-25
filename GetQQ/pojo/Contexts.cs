using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetQQ.pojo
{
    class Contexts
    {
        public int cid { get; set; }
        public int slid { get; set; }// 所属网页编号
        public string srcRow { get; set; }// 原行内容
        public long qqNum { get; set; }// QQ号
        public double price { get; set; }// -- 价格
        public int qqLv { get; set; }//	-- 等级
        public int qqAge { get; set; }//	-- Q龄
        public int qtid { get; set; }//	-- 类型 --关联
        public string radio { get; set; }// default '未出售',-- 交易状态 未出售/交易中/已卖出(默认都为未出售)
        public bool isFreeProtect { get; set; }//-- 是否送保
        public string wwKehu { get; set; }//-- 销售旺旺客服
        public string mima { get; set; }// 密码框
        public int isConn { get; set; }

    }
}
