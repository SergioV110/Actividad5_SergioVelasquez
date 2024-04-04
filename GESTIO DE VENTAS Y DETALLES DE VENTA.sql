CREATE DATABASE GESTIONDEVENTASYDETALLES

CREATE TABLE VENTAS
(
	IDVENTA INT IDENTITY (1,1) NOT NULL,
	FECHAVENTA DATETIME NOT NULL,
	TOTALVENTA MONEY NOT NULL,
	PRIMARY KEY (IDVENTA)
);

CREATE TABLE PRODUCTOS 
(
	IDPRODUCTO INT IDENTITY (1,1) NOT NULL,
	NOMBREPRODUCTO	NVARCHAR (50) NOT NULL,
	PRECIOUNITARIO MONEY NOT NULL,
	PRIMARY KEY (IDPRODUCTO)
);

CREATE TABLE DETALLEVENTA
(
	IDDETALLEVENTA INT IDENTITY (1,1) NOT NULL,
	IDVENTA INT NOT NULL,
	IDPRODUCTO INT NOT NULL,
	CANTIDAD NVARCHAR (50) NOT NULL,
	PRECIOUNITARIO MONEY NOT NULL,
	TOTALDETALLE MONEY NOT NULL,
	PRIMARY KEY (IDDETALLEVENTA),
	FOREIGN KEY (IDVENTA) REFERENCES VENTAS (IDVENTA),
	FOREIGN KEY (IDPRODUCTO) REFERENCES PRODUCTOS (IDPRODUCTO)
);

insert into ventas values('2022-02-01 22:00:00' ,'450');
insert into ventas values('2022-03-04 18:00:00' ,'320');
insert into ventas values('2022-04-01 17:00:00','720');
insert into ventas values('2022-05-10 11:00:00' ,'112');
insert into ventas values('2022-06-02 14:00:00' ,'450');
insert into ventas values('2022-07-07 12:00:00' ,'780');

SELECT * FROM VENTAS

insert into productos values('Red Dead Redemption 2' ,'150');
insert into productos values('God Of Ware Ragnarok' ,'60');
insert into productos values('Gran Turismo 7','220');
insert into productos values('Stray' ,'60');
insert into productos values('Forza Horizon 5' ,'200');
insert into productos values('Spiderman 2' ,'190');

SELECT * FROM PRODUCTOS

insert into detalleventa values (1,1, '3', '151', '455');
insert into detalleventa values (2,2, '5', '151', '325');
insert into detalleventa values (3,3, '7', '151', '725');
insert into detalleventa values (4,4, '3', '151', '115');
insert into detalleventa values (5,5, '4', '151', '455');
insert into detalleventa values (6,6, '8', '151', '785');

SELECT * FROM DETALLEVENTA