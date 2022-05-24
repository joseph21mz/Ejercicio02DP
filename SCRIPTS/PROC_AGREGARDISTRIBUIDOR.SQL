CREATE PROCEDURE PROC_AGREGARDISTRIBUIDOR (  @id VARCHAR(8),@fecharegistro date, @nombre varchar(30), @appaterno varchar(30), @apmaterno varchar(30),
@calle varchar(50),  @numero varchar(7), @colonia varchar(50))
/*
Autor: JOSÉ LUIS MEZA HERRERA.
Fecha: 20/05/2022
Decripción: Grabar los datos de los distribuidores de DP
Solicito: DP
*/
AS

	
BEGIN

	INSERT INTO addresses(calle, numero, colonia,id)
	VALUES(@calle,@numero, @colonia, @id );

	INSERT INTO distributors(id, fecharegistro)
	VALUES(@id,@fecharegistro);

	INSERT INTO persons(nombre,appaterno, apmaterno, id)
	VALUES(@nombre, @appaterno, @apmaterno, @id);
	

END
