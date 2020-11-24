create database concesionario

use concesionario

create table TipoVehiculo
(

	id int primary key,
	nombre varchar(25),

) 

/* Procedimientos almacenados */

go 
create proc addTipoVehiculo
(
	
	@id int,
	@nombre varchar(25)
	
)
as insert into TipoVehiculo values(@id,@nombre)


go
create proc updateTipoVehiculo
(

	@id int,
	@nombre varchar(25)

)
as 
begin
update TipoVehiculo set nombre = @nombre where id = @id
end


go
create proc deleteTipoVehiculo
(

	@id int

)
as
begin
delete from TipoVehiculo where id = @id
end


exec addTipoVehiculo 1,'Camion'
exec updateTipoVehiculo 4, 'Tren'
exec deleteTipoVehiculo 7

select * from TipoVehiculo

/*******************************************************************************/


create table Vehiculo
(
		
		id int primary key,
		marca varchar(25) unique,
		modelo varchar(25) not null,
		placa varchar(10) not null,
		anio int not null,
		idtv int not null,
		constraint rel_a_tipoVeh foreign key (idtv) references TipoVehiculo (id)

)

go 
create proc addVehiculo
(
		
		@id int,
		@marca varchar(25),
		@modelo varchar(25),
		@placa varchar(10),
		@anio int,
		@idtv int
		

)
as insert into Vehiculo values(@id,@marca,@modelo,@placa, @anio,@idtv)


go
create proc updateVehiculo
(

		@id int,
		@marca varchar(25),
		@modelo varchar(25),
		@placa varchar(10),
		@anio int,
		@idtv int

)
as 
begin
update Vehiculo set marca = @marca, modelo = @modelo, placa = @placa, anio = @anio, idtv = @idtv where id = @id
end

go
create proc deleteVehiculo
(
	
	@id int

)
as
begin
delete from Vehiculo where id = @id
end

exec addVehiculo  1,'Chevrolet', 'Miata', 'asd123', 2019, 3
exec updateVehiculo 1, 'Renault', 'Stepway', 'abc123', 2020, 3 
exec deleteVehiculo 3


/**********************************************************************************/

create table TipoConductor
(
	idtc int primary key,
	tipoPersona varchar(25) not null

)

go 
create proc addTipoConductor
(
	
	@idtc int,
	@tipoPersona varchar(25)
	
)
as insert into TipoConductor values(@idtc,@tipoPersona)

exec addTipoConductor 4,'Maquinista'
exec addTipoConductor 5,'Busero'

go
create proc updateTipoConductor
(

	@idtc int,
	@tipoPersona varchar(25)

)
as 
begin
update TipoConductor set tipoPersona = @tipoPersona where idtc = @idtc
end

exec updateTipoConductor 1, 'Camionero'

go
create proc deleteTipoConductor
(

	@idtc int

)
as
begin
delete from TipoConductor where idtc = @idtc
end

exec deleteTipoConductor 4

select * from TipoConductor
select * from TipoVehiculo


/*****************************************************************************************/

create table conductor
(
			
		idcond int primary key,
		nombre varchar(25) unique,
		tipoLicencia varchar(25) not null,
		idVehiculo int not null,
		idTipoConductor int not null,
		constraint rel_a_Vehiculo foreign key (idVehiculo) references Vehiculo (id),
		constraint rel_a_tipoConductor foreign key (idTipoConductor) references TipoConductor (idtc)

)

go 
create proc addConductor
(
	@idcond int,
	@nombre varchar(25),
	@tipoLicencia varchar(25),
	@idVehiculo int,
	@idTipoConductor int

)
as insert into conductor values(@idcond,@nombre,@tipoLicencia,@idVehiculo, @idTipoConductor)

exec addConductor  3,'Luisa Toro', 'B2', 2, 1


go
create proc updateConductor
(

	@idcond int,
	@nombre varchar(25),
	@tipoLicencia varchar(25),
	@idVehiculo int,
	@idTipoConductor int

)
as
begin
update conductor set nombre = @nombre, tipoLicencia = @tipoLicencia, idVehiculo = @idVehiculo, idTipoConductor = @idTipoConductor where idcond = @idcond
end

exec updateConductor 1, 'Jorge Enrique', 'B1', 1, 3

go
create proc deleteConductor
(

	@idcond int

)
as
begin
delete from conductor where idcond = @idcond
end

exec deleteConductor 3


select * from conductor
select * from Vehiculo
select * from TipoConductor

/****************************************************************************************/

create table contrato
(
	
	idContrato int primary key,
	idConductor int not null,
	idVehiculo int not null,
	constraint rel_a_conductor foreign key (idConductor) references conductor (idcond),
	constraint rel_a_Vehiculo2 foreign key (idVehiculo) references Vehiculo (id)
)


go
create proc addContrato
(

	@idContrato int,
	@idConductor int,
	@idVehiculo int
	
)
as insert into contrato values(@idContrato,@idConductor,@idVehiculo)

exec addContrato 4,4,4


go
create proc updateContrato
(

	@idContrato int,
	@idConductor int,
	@idVehiculo int

)
as
begin
update contrato set idConductor = @idConductor, idVehiculo = @idVehiculo where idContrato = @idContrato
end

exec updateContrato 3, 3, 4

go
create proc deleteContrato
(
	
	@idContrato int

)
as
begin
delete from contrato where idContrato = @idContrato
end

exec deleteContrato 3


select * from contrato
select * from Vehiculo
select * from conductor
select * from ruta
select * from TipoConductor
select * from TipoVehiculo



/*************************************************************************************/

create table ruta
(
	
	idRuta int primary key,
	estacion varchar(25) not null,
	idVehiculo2 int not null,
	constraint rel_a_Vehiculo3 foreign key (idVehiculo2) references Vehiculo (id)

)

EXECUTE sp_rename 'ruta.idVehiculo2', 'idVehiculo', 'COLUMN'

go
create proc addruta
(
	
	@idRuta int,
	@estacion varchar(25),
	@idVehiculo int
)
as insert into ruta values(@idRuta,@estacion,@idVehiculo)

exec addruta 2,'Carabobo',2

go
create proc updateRuta
(

	@idRuta int,
	@estacion varchar(25),
	@idVehiculo int

)
as 
begin
update ruta set estacion = @estacion, idVehiculo = @idVehiculo where idRuta = @idRuta
end


exec updateRuta 2, 'Cisneros', 2

go
create proc deleteRuta
(
	
	@idRuta int

)
as
begin
delete from ruta where idRuta = @idRuta
end

exec deleteRuta 2

