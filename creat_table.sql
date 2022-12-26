create table Books(
    Bid varchar(20) PRIMARY KEY,
    Bname VARCHAR(20),
    Bauthor varchar(20),
    Bpbr varchar(40),
    Bnum int,
    Btype varchar(20)
)

create table Students(
    Sid varchar(20) PRIMARY KEY,
    Sname varchar(10),
    Ssex varchar(2),
    Sdept varchar(20),
    Smajor varchar(20),
    Sgrade int
)

create table Users(
    Uid varchar(20) PRIMARY KEY,
    Uname varchar(20),
    Upsd varchar(20),
    Ustate varchar(10)
)

create table US(
    Uid varchar(20) ,
    Sid varchar(20) ,
    PRIMARY KEY(Uid,Sid),
    FOREIGN KEY (Uid)
    REFERENCES Users(Uid),
    FOREIGN KEY(Sid)
    REFERENCES Students(Sid)
)

create table Borrow(
    Bid varchar(20),
    Uid varchar(20),
    Bdate DATE,
    Ddate DATE,
    Bstate varchar(10),
    PRIMARY KEY (Bid,Uid),
    FOREIGN KEY (Bid)
    REFERENCES Books(Bid),
    FOREIGN KEY (Uid) 
    REFERENCES Users(Uid)
)