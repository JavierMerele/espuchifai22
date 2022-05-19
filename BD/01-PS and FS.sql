USE Espuchifai;

DELIMITER $$

DROP PROCEDURE IF EXISTS altaBanda $$
CREATE PROCEDURE altaBanda (unnombre VARCHAR(45),unafundacion YEAR,unidBanda SMALLINT UNSIGNED)

BEGIN
                        INSERT INTO Banda ( nombre, fundacion, idBanda)
                                VALUES (unnombre , unafundacion , unidBanda);

END$$ 





DELIMITER $$
 
DROP PROCEDURE IF EXISTS  altaAlbum $$
CREATE PROCEDURE altaAlbum ( unnombre  VARCHAR(45) , unlanzamiento DATE , unidBanda SMALLINT UNSIGNED , unidAlbum MEDIUMINT UNSIGNED )
 
BEGIN
                        INSERT INTO  Album (nombre , lanzamiento , idBanda, idAlbum )
                                VALUES ( unnombre , unlanzamiento , unidBanda , unidAlbum );
                           
END$$
 
DELIMITER $$
 
DROP PROCEDURE IF EXISTS altaCancion $$
CREATE PROCEDURE altaCancion ( unnombre  VARCHAR(45) , unorden TINYINT UNSIGNED , unidAlbum MEDIUMINT UNSIGNED , unidCancion INT UNSIGNED)
 
BEGIN
                        INSERT INTO Cancion ( nombre , orden ,idAlbum , idCancion )
                                VALUES ( unnombre , unorden , unidAlbum , unidCancion);
                       
END$$

DELIMITER $$
 
DROP PROCEDURE IF EXISTS Reproducir $$
CREATE PROCEDURE Reproducir ( unareproduccion DATETIME , unidCancion INT UNSIGNED , unidUsuario SMALLINT UNSIGNED)

BEGIN 
					INSERT INTO Reproduccion (reproduccion, idCancion, idUsuario)
							VALUES ( unareproduccion, unidCancion, unidUsuario);

END$$
 
-- 2) Se pide hacer el SP ‘registrarCliente’ que reciba los datos del cliente. Es importante guardar encriptada la contraseña del cliente usando SHA256
 
DELIMITER $$
DROP PROCEDURE IF EXISTS registrarCliente $$
CREATE PROCEDURE registrarCliente ( unNombre VARCHAR(45), unApellido VARCHAR (45), unEmail VARCHAR(45), unaContrasenia CHAR(64), unidUsuario SMALLINT UNSIGNED)
 
BEGIN
            INSERT INTO  Usuario ( nombre, apellido, email, contrasenia,idUsuario )
                        VALUES (unNombre, unApellido ,unEmail ,SHA2 (unaContrasenia,256) , unidUsuario);
END$$
 
                       
-- 3) Se pide hacer el SF ‘CantidadReproduccionesBanda’ que reciba por parámetro un identificador de banda y 2 fechas,se debe devolver la cantidad de reproducciones que tuvieron las canciones de esa banda entre esas 2 fechas (inclusive).
 
 
DELIMITER $$
DROP FUNCTION IF EXISTS CantidadReproduccionesBanda $$
CREATE FUNCTION CantidadReproduccionesBanda (unidBanda SMALLINT UNSIGNED , unInicio DATETIME , unFin  DATETIME)
                                                RETURNS DATETIME reads sql data
 
BEGIN
        DECLARE resultado DATETIME;
       
        SELECT COUNT(*) INTO resultado
        FROM Reproduccion
        INNER JOIN Cancion USING(idCancion)
        INNER JOIN Album USING(idAlbum)
        WHERE idBanda = unidBanda
        AND reproduccion BETWEEN unInicio and unFin;
       
 
        RETURN resultado ;
 
END $$
 
-- 4) Se pide hacer el SP ‘Buscar’ que reciba por parámetro una cadena. El SP tiene que devolver las canciones que contengan la cadena en su título, nombre de álbum o nombre de banda
 
DELIMITER $$
DROP PROCEDURE IF EXISTS Buscar $$
CREATE PROCEDURE Buscar (cadena VARCHAR(45))
BEGIN
        SELECT C.nombre , orden , C.idAlbum, C.idCancion
        FROM Cancion C
        JOIN Album USING (idAlbum)
        WHERE MATCH (C.nombre, A.nombre, B.nombre) AGAINST (cadena);
 
END $$
 
 
 
 
 
 
DELIMITER ;
USE Espuchifai;
    CALL altaBanda ('ACDC', '1978' , 9 );
 
    CALL altaAlbum ('Back in Black', '1980-09-25' , 9, 4 );
 
    CALL altaAlbum ('powerage', '1978-05-05' , 9 , 7);
 
    CALL altaCancion ('Hells Bells', 1 , 4 , 10 );
    CALL altaCancion ('Shoot to trill', 2 , 4 , 11 );
    CALL altaCancion ('What do you for monney honey', 3 , 4 , 12 );
 
    CALL altaCancion ('Rock  Roll Damnation ', 1 , 7 , 13 );
    CALL altaCancion ('Down Payment Blues', 2 , 7 , 14 );
    CALL altaCancion ('Gimme a Bullet', 3 , 7 , 15 );
    
    
    CALL registrarCliente('Valentina' ,'Gutierrez', 'gutierreez01@gmail.com' , 'Estrellas28', 58);
    
    
    
    
    
    
    
    
    
    CALL Reproducir (now() , 10 , 58)
 
 

 
