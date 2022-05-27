CREATE PROCEDURE PROC_CONSULTARDISTRIBUIDOR (  @id VARCHAR(8))
/*
Autor: JOS� LUIS MEZA HERRERA.
Fecha: 20/05/2022
Decripci�n: Consultar los datos de los distribuidores de DP
Solicito: DP
*/
AS
DECLARE
	
BEGIN

	SELECT CONCAT (a.nombre, ' ', a.appaterno,' ', a.apmaterno) AS nombre, b.calle, b.numero,b.colonia 
	FROM persons AS a
	INNER JOIN addresses AS b ON (a.id = b.id)
	INNER JOIN distributors AS c ON (b.id = c.id)
	WHERE c.id =@id;
	

END
GO
--EXEC PROC_CONSULTARDISTRIBUIDOR 'AK1P850A';

