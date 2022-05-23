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

drop PROCEDURE PROC_AGREGARDISTRIBUIDOR 

EXEC PROC_AGREGARDISTRIBUIDOR  'AK1P850A','20200705', 'LILIANA','FLORES','MADRIGAL',
'CALEXICO', '5801','BUROCRATA'

SELECT * FROM addresses;
SELECT * FROM distributors;
SELECT * FROM persons;

DROP TABLE addresses;
DROP TABLE  distributors;
DROP TABLE persons;

CREATE TABLE distributors(
id varchar(8),
fecharegistro date
);
CREATE TABLE addresses(
calle varchar(30),
numero varchar(8),
colonia varchar(30),
id varchar(8)
);
CREATE TABLE persons(
nombre varchar(30),
appaterno varchar(30),
apmaterno varchar(30),
id varchar(8)
);

SELECT CONCAT (a.nombre, ' ', a.appaterno,' ', a.apmaterno) AS nombre, b.calle, b.numero,b.colonia 
FROM persons AS a
INNER JOIN addresses AS b ON (a.id = b.id)
INNER JOIN distributors AS c ON (b.id = c.id)
WHERE c.id ='AK1P850A'
