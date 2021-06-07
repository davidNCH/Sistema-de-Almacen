create database almacen
	go

use  almacen
go
if exists (select *from sysobjects  where type='U' and name='almacen')
drop TABLE PRODUCTOS
	create TABLE PRODUCTOS(
	 codigo int not null, 
	 descripcion varchar(50) not null,
	  marca  varchar(30) not null,
	 medida varchar(15) not null, 
	 stock float not null,
	 precio float not null, 
	  igv float not null,
	 total float NOT NULL,
	  fechavence date not null,
	 tipo varchar(35) not null, primary key(codigo)) 
	go

	use almacen
	go

	insert into PRODUCTOS(codigo,descripcion,marca,medida,	stock,precio,igv,total,fechavence,tipo)
	values  ( 01,"gaseosa","inka kola","lt", 20, 2, '02/12/2019'," perecible"   )

	insert into PRODUCTOS(codigo,descripcion,marca,medida, stock,precio,igv,total,fechavence,tipo)values
		 (02,"vino"," abuelo","lt",10, 3, '12/09/2020', " perecible")

	insert into PRODUCTOS(codigo,descripcion,marca,medida, stock,precio,igv,total,fechavence,tipo)values
        (03,"arroz"," gallito", "kg", 20, 100, '23/10/2020'," perecible")


	insert into PRODUCTOS(codigo,descripcion,marca,medida,stock,precio,igv,total,fechavence,tipo)values
	(04,"fideo","lavalli", "kg", 10, 10, '23/04/2020'," perecible")

		insert into PRODUCTOS(codigo,descripcion,marca,medida,stock,precio,igv,total,fechavence,tipo)values
		(05,"leche","gloria","lt", 20,2, '29/06/2020',"perecible")
  
insert into PRODUCTOS(codigo,descripcion,marca,medida ,stock,precio,igv,total,fechavence,tipo)values
           ( 0010, "atun gloria", "gloria", "gr", 30, 2, '26/07/2020',"no perecible"

		go

		select*from almacen
		go