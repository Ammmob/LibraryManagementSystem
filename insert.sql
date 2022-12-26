-- insert into 
-- Books(Bid,Bname,Bauthor,Bpbr,Bnum,Btype)
-- VALUES('9787302423287','机器学习','周志华','清华大学出版社',3,'工学'),
-- ('9787115461476','深度学习','伊恩·古德费罗','人民邮电出版社',1,'工学')

-- insert into 
-- Students
-- values('20040031010','华佳彬','男','信息科学与工程学部','智能科学与技术',2020),
-- ('19040031010','张伟','男','海洋地球科学学院','勘查技术与工程',2019)

-- insert into 
-- Users
-- VALUES('000000','Mob','123456','管理员'),
-- ('000001','Haha','112233','普通用户')

-- insert into 
-- US 
-- values('000000','20040031010'),('000001','19040031010')
-- update Books
-- set Bnum='1',
-- Btype='工学'
-- where Bid='9787115461476'

-- insert into 
-- Students
-- values('19040031020','李华','女','信息科学与工程学部','计算机科学与技术',2019)



-- insert into 
-- Students
-- values('32134325401','张三','男','法学院','法学',2018),
-- ('32445222127','王二','女','外国语学院','英语',2021),
-- ('32445222124','刘思','女','外国语学院','德语',2022)

select * from students
select * from users
select * from us
select* from Borrow
select * from books

--delete from Borrow where uid='000000'
-- select * from Borrow
-- where bid='9787115461476'
-- and uid='000000'