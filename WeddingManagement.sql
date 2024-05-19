create table ACCOUNT(
	Id bigint primary key,
	Username nvarchar(64),
	Pw nvarchar(1000),
	Priority smallint,
	Name nvarchar(100),
	Identification varchar(20),
)

create table LOBBY_TYPE
(
	IdLobbyType varchar(21) primary key,	--Khóa chisnhh (LT)
	LobbyName nvarchar(100) not null,
	MinTablePrice bigint,
	Available int,
)
insert into LOBBY_TYPE values('LT0000000000000000001', N'A', 1000000, 1)
insert into LOBBY_TYPE values('LT0000000000000000002', N'B', 1100000, 1)
insert into LOBBY_TYPE values('LT0000000000000000003', N'C', 1200000, 1)
insert into LOBBY_TYPE values('LT0000000000000000004', N'D', 1400000, 1)
insert into LOBBY_TYPE values('LT0000000000000000005', N'E', 1600000, 1)

create table LOBBY
(
	IdLobby varchar(21) primary key,	--//Khóa chisnhh (LO)
	IdLobbyType varchar(21) not null,
	LobbyName nvarchar(40) not null,
	MaxTable int,
	Available int,
	Note nvarchar(1000),
	constraint FK_IdLobbyType foreign key (IdLobbyType) references LOBBY_TYPE (IdLobbyType),
)
insert into LOBBY values('LB0000000000000000001', 'LT0000000000000000001', N'Sảnh A1', 20, 1, N'')
insert into LOBBY values('LB0000000000000000002', 'LT0000000000000000002', N'Sảnh B1', 25, 1, N'')
insert into LOBBY values('LB0000000000000000003', 'LT0000000000000000003', N'Sảnh C1', 30, 1, N'')
insert into LOBBY values('LB0000000000000000004', 'LT0000000000000000004', N'Sảnh D1', 40, 1, N'')
insert into LOBBY values('LB0000000000000000005', 'LT0000000000000000005', N'Sảnh E1', 50, 1, N'')
insert into LOBBY values('LB0000000000000000006', 'LT0000000000000000005', N'Sảnh E2', 45, 1, N'')
insert into LOBBY values('LB0000000000000000007', 'LT0000000000000000004', N'Sảnh D2', 35, 1, N'')
insert into LOBBY values('LB0000000000000000008', 'LT0000000000000000003', N'Sảnh C2', 30, 1, N'')
insert into LOBBY values('LB0000000000000000009', 'LT0000000000000000002', N'Sảnh B2', 25, 1, N'')
insert into LOBBY values('LB0000000000000000010', 'LT0000000000000000001', N'Sảnh A2', 20, 1, N'')

create table SHIFT
(
	IdShift varchar(21) primary key,	--//Khóa chisnhh (SH)
	Available int,
	ShiftName nvarchar(20),
	Starting time,
	Ending time,
)
insert into SHIFT values('SH0000000000000000001', 1, N'Trưa', '12:00', '16:00')
insert into SHIFT values('SH0000000000000000002', 1, N'Tối', '17:00', '22:00')


 create table WEDDING_INFOR
 (
	IdWedding varchar(21) primary key,	--//Khóa chisnhh (WD)
	IdLobby varchar(21) not null,
	IdShift varchar(21),
	BookingDate datetime,
	WeddingDate datetime,
	PhoneNumber varchar(10),
	GroomName nvarchar(100),
	BrideName nvarchar(100),
	AmountOfTable int,
	AmountOfContingencyTable int,
	TablePrice bigint,
	Deposit bigint,
	Available int,
	Representative nvarchar(100) not null,
	constraint FK_IdLobby foreign key (IdLobby) references LOBBY (IdLobby),
	constraint FK_IdShift foreign key (IdShift) references SHIFT (IdShift),
 )

 set dateformat dmy;
create table  MENU
(
	IdDishes varchar(21) primary key,	--//Khóa chisnhh (MN)
	DishesName nvarchar(100),
	DishesPrice bigint,
	Note nvarchar(100),
	Available int,
)
INSERT INTO MENU VALUES
('MN001', N'Gà chiên nước mắm', 100000, N'', 1),
('MN002', N'Cá kho tộ', 120000, N'', 1),
('MN003', N'Tôm hấp bia', 150000, N'', 1),
('MN004', N'Mực xào chua ngọt', 110000, N'', 1),
('MN005', N'Bò lúc lắc', 130000, N'', 1),
('MN006', N'Cơm chiên hải sản', 90000, N'', 1),
('MN007', N'Mì xào hải sản', 95000, N'', 1),
('MN008', N'Gỏi cuốn tôm thịt', 80000, N'', 1),
('MN009', N'Gỏi ngó sen tôm thịt', 85000, N'', 1),
('MN010', N'Sườn non ram mặn', 115000, N'', 1),
('MN011', N'Canh chua cá lóc', 90000, N'', 1),
('MN012', N'Canh bí đỏ nấu tôm', 80000, N'', 1),
('MN013', N'Tôm rang muối', 120000, N'', 1),
('MN014', N'Mì xào bò', 100000, N'', 1),
('MN015', N'Gà hấp lá chanh', 110000, N'', 1),
('MN016', N'Gà xào sả ớt', 100000, N'', 1),
('MN017', N'Cá chiên giòn', 120000, N'', 1),
('MN018', N'Cá hấp bầu', 130000, N'', 1),
('MN019', N'Mực nướng mỡ hành', 110000, N'', 1),
('MN020', N'Mì xào tôm', 90000, N'', 1),
('MN021', N'Gỏi gà', 85000, N'', 1),
('MN022', N'Canh giò hầm rau củ', 90000, N'', 1),
('MN023', N'Canh gà hầm thuốc bắc', 80000, N'', 1),
('MN024', N'Tôm sốt me', 120000, N'', 1),
('MN025', N'Mì xào cá viên', 100000, N'', 1),
('MN026', N'Gà hấp lá giang', 110000, N'', 1),
('MN027', N'Gà kho', 100000, N'', 1),
('MN028', N'Cá hồi áp chảo', 120000, N'', 1),
('MN029', N'Cá hấp bầu', 130000, N'', 1),
('MN030', N'Mực nướng sa tế', 110000, N'', 1),
('MN031', N'Mì xào rau cải', 90000, N'', 1),
('MN032', N'Gỏi gà măng cụt', 85000, N'', 1),
('MN033', N'Canh rau mùng tơi', 90000, N'', 1),
('MN034', N'Gỏi bắp bò', 80000, N'', 1),
('MN035', N'Tôm sốt trứng muối', 120000, N'', 1),
('MN036', N'Mì xào mực', 100000, N'', 1),
('MN037', N'Gà hấp muối ớt', 110000, N'', 1),
('MN038', N'Gà chiên giòn', 100000, N'', 1),
('MN039', N'Cá chép chiên giòn', 120000, N'', 1),
('MN040', N'Cá hấp hành', 130000, N'', 1),
('MN041', N'Mực nhồi thịt', 110000, N'', 1),
('MN042', N'Mì xào thịt bằm', 90000, N'', 1),
('MN043', N'Gỏi tai heo', 85000, N'', 1),
('MN044', N'Canh chua cá bóp', 90000, N'', 1),
('MN045', N'Canh bí đỏ sườn non', 80000, N'', 1),
('MN046', N'Tôm ram thịt', 120000, N'', 1),
('MN047', N'Mì ý sốt kem', 100000, N'', 1),
('MN048', N'Gà hấp tiêu đen', 110000, N'', 1),
('MN049', N'Gà nướng', 100000, N'', 1),
('MN050', N'Cá diêu hồng nấu ngọt', 120000, N'', 1),
('MN051', N'Cá lăng kho tộ', 130000, N'', 1),
('MN052', N'Mực chiên giòn', 110000, N'', 1),
('MN053', N'Mì ý sốt cua', 90000, N'', 1),
('MN054', N'Gỏi thịt bò xào', 85000, N'', 1),
('MN055', N'Canh rau cải nấu thịt', 90000, N'', 1),
('MN056', N'Canh cà chua trứng', 80000, N'', 1),
('MN057', N'Hải sản xào chua ngọt', 120000, N'', 1),
('MN058', N'Bò nhúng giấm', 100000, N'', 1),
('MN059', N'Cơm chiên muối ớt', 70000, N'', 1),
('MN060', N'Cơm chiên trứng', 80000, N'', 1),
('MN061', N'Cơm chiên sa tế', 90000, N'', 1),
('MN062', N'Sườn xào chua ngọt', 100000, N'', 1),
('MN063', N'Sườn nướng mật ong', 150000, N'', 1),
('MN064', N'Sườn nướng sốt BBQ', 120000, N'', 1),
('MN065', N'Sườn non xào xả ớt', 100000, N'', 1),
('MN066', N'Tôm chiên giòn', 140000, N'', 1),
('MN067', N'Tôm nướng sốt sa tế', 130000, N'', 1),
('MN068', N'Tôm hùm sốt phô mai', 300000, N'', 1),
('MN069', N'Tôm hùm đất sốt cajun', 160000, N'', 1),
('MN070', N'Gỏi bắp bò', 100000, N'', 1),
('MN071', N'Súp cua bắp non', 110000, N'', 1),
('MN072', N'Cá tai tượng chưng tương', 130000, N'', 1),
('MN073', N'Gà lên mâm', 200000, N'', 1),
('MN074', N'Lẫu hải sản', 220000, N'', 1),
('MN075', N'Súp gà nấm đông cô', 120000, N'', 1),
('MN076', N'Cá chẽm hấp hồng kong', 230000, N'', 1),
('MN077', N'Lẫu ếch đồng', 260000, N'', 1),
('MN078', N'Bò nấu lagu', 160000, N'', 1),
('MN079', N'Tôm hấp bia', 150000, N'', 1),
('MN080', N'Lẫu cá măng chua', 180000, N'', 1),
('MN081', N'Gỏi sứa', 180000, N'', 1),
('MN082', N'Súp cua tóc tiên', 100000, N'', 1),
('MN083', N'Bò hầm tiêu xanh', 170000, N'', 1),
('MN084', N'Tôm sú hấp trái dứa', 190000, N'', 1),
('MN085', N'Lẫu hải sản sốt thái', 230000, N'', 1),
('MN086', N'Súp cua tôm thịt rau củ', 120000, N'', 1),
('MN087', N'Gà ủ muối hoa tiêu', 200000, N'', 1),
('MN088', N'Bò hầm vang đỏ bánh mì', 210000, N'', 1),
('MN089', N'Mực hấp hành gừng', 150000, N'', 1),
('MN090', N'Lẫu cua biển và bún', 200000, N'', 1),
('MN091', N'Cá bông mú hấp xì dầu', 240000, N'', 1),
('MN092', N'Xôi bồ câu', 220000, N'', 1),
('MN093', N'Lẫu gà lá é', 250000, N'', 1),
('MN094', N'Salad trứng cá hồi', 130000, N'', 1),
('MN095', N'Gà bó xôi', 250000, N'', 1),
('MN096', N'Hàu nướng mỡ hành', 200000, N'', 1),
('MN097', N'Súp măng tây', 100000, N'', 1),
('MN098', N'Bánh hỏi thịt chiên giòn', 200000, N'', 1),
('MN099', N'Dê hấp tía tô', 250000, N'', 1),
('MN100', N'Gà quay bánh bao', 230000, N'', 1);



create table SERVICE
(
	IdService varchar(21) primary key, --//Khóa chisnhh (SV)
	ServiceName nvarchar(100),
	ServicePrice bigint,
	Note nvarchar(100),
	Available int,
)
insert into SERVICE values('SV0000000000000000001', N'bưng bàn ghế', 1000000, N'', 1)
insert into SERVICE values('SV0000000000000000002', N'treo hoa', 500000, N'', 1)
insert into SERVICE values('SV0000000000000000003', N'bơm bóng bay', 100000, N'', 1)
insert into SERVICE values('SV0000000000000000004', N'in ấn thiệp cưới', 100000, N'', 1)
insert into SERVICE values('SV0000000000000000005', N'thuê trang phục cưới', 100000, N'', 1)
insert into SERVICE values('SV0000000000000000006', N'trang trí tiệc cưới', 100000, N'', 1)
insert into SERVICE values('SV0000000000000000007', N'chụp hình quay phim', 1000000, N'', 1)
insert into SERVICE values('SV0000000000000000008', N'trang điểm ngày cưới', 100000, N'', 1)
insert into SERVICE values('SV0000000000000000009', N'trợ lí ngày cưới', 200000, N'', 1)
insert into SERVICE values('SV0000000000000000010', N'điều phối chương trình lễ cưới', 500000, N'', 1)
insert into SERVICE values('SV0000000000000000011', N'dịch vụ âm thanh và ánh sáng ngày cưới', 1000000, N'', 1)
insert into SERVICE values('SV0000000000000000012', N'ban nhạc trình diễn', 2000000, N'', 1)
insert into SERVICE values('SV0000000000000000013', N'dịch vụ bắn pháo hoa', 1000000, N'', 1)
insert into SERVICE values('SV0000000000000000014', N'dịch vụ dọn dẹp sau tiệc cưới', 1000000, N'', 1)
insert into SERVICE values('SV0000000000000000015', N'dịch vụ đưa đón', 1000000, N'', 1)
insert into SERVICE values('SV0000000000000000016', N'dịch vụ trang trí bàn thờ gia tiên', 300000, N'', 1)
insert into SERVICE values('SV0000000000000000017', N'dịch vụ chọn mâm ngũ quả', 100000, N'', 1)
insert into SERVICE values('SV0000000000000000018', N'dịch vụ trao đổi loại hình và phương án thực hiện', 500000, N'', 1)
insert into SERVICE values('SV0000000000000000019', N'dịch vụ tổ chức hội thảo hội nghị', 100000, N'', 1)
insert into SERVICE values('SV0000000000000000020', N'dịch vụ khác: sinh nhật, thôi nôi', 1000000, N'', 1)

create table TABLE_DETAIL
(
	IdWedding varchar(21) not null,
	IdDishes varchar(21) not null,
	AmountOfDishes int,
	TotalDishesPrice bigint,
	Note nvarchar(100),
	constraint PK_TABLE_DETAIL primary key (IdWedding,IdDishes),
	constraint FK_IdWedding foreign key (IdWedding) references WEDDING_INFOR (IdWedding),
	constraint FK_IdDishes foreign key (IdDishes) references MENU (IdDishes)
)

create table SERVICE_DETAIL
(
	IdWedding varchar(21) not null,
	IdService varchar(21) not null,
	AmountOfService int,
	TotalServicePrice bigint,
	Note nvarchar(50),
	constraint PK_SERVICE_DETAIL primary key (IdWedding,IdService),
	constraint FK_Service_IdWedding foreign key (IdWedding) references WEDDING_INFOR (IdWedding),
	constraint FK_IdService foreign key (IdService) references [SERVICE] (IdService),
)

create table BILL
(
	IdBill varchar(21) primary key,   --//Khóa chisnhh(BI)=idWedding
	InvoiceDate datetime,
	TablePriceTotal bigint,
	ServicePriceTotal bigint,
	Total bigint,
	PaymentDate datetime,
	MoneyLeft bigint,
	staff bigint,
	constraint FK_Staff foreign key (staff) references ACCOUNT(Id),
	constraint FK_Bill_IdWedding foreign key (idBill) references WEDDING_INFOR(IdWedding)
)


create table REVENUE_REPORT
(
	IdReport varchar(21) primary key, --//Khóa chisnhh (RR)
	Month tinyint,
	Year int,
	RevenueTotal bigint,
)

create table REVENUE_REPORT_DT
(
	IdReport varchar(21) not null,  
	Day tinyint not null,
	DayRevenue bigint,
	Ratio float,
	AmoutOfWedding int,
	constraint PK_REVENUE_REPORT_DT primary key (IdReport,Day),
	constraint FK_IdReport foreign key (IdReport) references REVENUE_REPORT(IdReport),
)

create table PARAMETER
(
	IdParamater varchar(20) primary key,	--//Khóa chisnhh (PA)
	Value int ,
)

insert into PARAMETER values ('recruiter', 1) -- chỉ người có priority <= 1 mới có quyền thu nhận nhân viên mới
insert into PARAMETER values ('MaxTable', 50) -- 1 phòng cưới chỉ có tối đa 50 bàn
insert into PARAMETER values ('PenaltyRate', 1) -- tiền phạt trả trễ là 1% / ngày
insert into PARAMETER values ('RulesFollowing', 1) -- 1 = áp dụng tiền phạt (phía trên), 0 = không áp dụng


insert into ACCOUNT (Id, Username, Pw, Priority, Name, Identification) values (0, N'123', N'123', 0, N'Lê Đinh Quốc Huy', N'079201019151')
insert into ACCOUNT (Id, Username, Pw, Priority, Name, Identification) values (1, N'200', N'200', 0, N'Nguyễn Đức Anh', N'079203011301')
insert into ACCOUNT (Id, Username, Pw, Priority, Name, Identification) values (2, N'300', N'300', 0, N'Lê Đinh Quốc Huy', N'079201019151')
