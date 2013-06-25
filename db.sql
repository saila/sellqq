create database QQDB;
use QQDB;
create table seller(
	sid int primary key not null auto_increment,
	sWwNum varchar(20),-- 旺旺号
	sName varchar(20),-- 卖家姓名
	sPhone varchar(20),-- 手机号
	sQQ varchar(20),-- 卖家QQ
	typeName varchar(255),-- 分类名称
	urlIn varchar(255), -- 选号地址
	tag long -- 标识码
);
create table sladdr(
	slid int primary key not null auto_increment,
	sid int,-- fladdr flid
	title varchar(255),-- 标题
	titleNote varchar(255),-- 标题备注
	url varchar(255),-- 二级网址
	note varchar(255),-- 备注
	lrow int,-- 前面去掉行数
	rrow int,-- 后面去掉行数
	srcCode text,-- 源代码(注)
	numTotal int,-- 号码总数
	lastTime date -- 上次采集时间
);
-- 号码类型
create table qqtype(
	qtid int, 
	qtName varchar(30)
);
insert into qqtype values(1,'QQ');
insert into qqtype values(2,'群');
insert into qqtype values(4,'连');
insert into qqtype values(8,'靓');
create table contexts(
	cid int primary key not null auto_increment,
	slid int, -- 所属网页编号
	srcRow varchar(255),-- 原行内容
	qqNum long, -- QQ号
	price double, -- 价格
	qqLv int,	-- 等级
	qqAge int,	-- Q龄
	qtid int,	-- 类型 --关联
	radio varchar(5) not null default '未出售',-- 交易状态 未出售/交易中/已卖出(默认都为未出售)
	isFreeProtect bool, -- 是否送保
	wwKehu varchar(20),-- 销售旺旺客服
	mima varchar(50),-- 密码框
	isConn int default 0  -- 连号标记
);
create table salessc(
	appvalues varchar(20) not null ,
	valuetype varchar(20) not null
);

insert salessc values("123456","销售旺旺客服");
insert salessc values("12345678","销售旺旺客服");
 



