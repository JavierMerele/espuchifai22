-- 1) Realizar los SP para dar de alta todas las entidades menos las tablas Cliente y Reproducción. En la tabla reproducción el SP se debe llamar ‘Reproducir’.

DELIMITER $$
DROP PROCEDURE IF EXISTS Reproducir $$
CREATE PROCEDURE  Reproducir ( unnombre  VARCHAR(45) , unafundacion YEAR , unidBanda SMALLINT UNSIGNED )

BEGIN
			INSERT INTO Banda ( nombre , fundacion , idBanda)
						VALUES ( unnombre , unafundacion , unidBanda);

END$$

DELIMITER $$

DROP PROCEDURE IF EXISTS Reproducir $$
CREATE PROCEDURE Reproducir ( unnombre  VARCHAR(45) , unlanzamiento DATE , unidBanda SMALLINT UNSIGNED , unidAlbum MEDIUMINT UNSIGNED )

BEGIN 
			INSERT INTO  Album (nombre , lanzamiento , idBanda, idAlbum )
							VALUES ( unnombre , unlanzamiento , unidBanda , unidAlbum );
                            
END$$

DELIMITER $$

DROP PROCEDURE IF EXISTS Reproducir $$
CREATE PROCEDURE Reproducir ( unnombre  VARCHAR(45) , unorden TINYINT UNSIGNED , unidAlbum MEDIUMINT UNSIGNED , unidCancion INT UNSIGNED)

BEGIN
			INSERT INTO Cancion ( nombre , orden ,idAlbum , idCancion )
						VALUES ( unnombre , unorden , unidAlbum , unidCancion);
                        
END$$

-- 2) Se pide hacer el SP ‘registrarCliente’ que reciba los datos del cliente. Es importante guardar encriptada la contraseña del cliente usando SHA256
 
DELIMITER $$
DROP PROCEDURE IF EXISTS registrarCliente $$
CREATE PROCEDURE registrarCliente ( unNombre VARCHAR(45), unApellido VARCHAR (45), unEmail VARCHAR(45), unaContraseña CHAR(64), unidUsuario SMALLINT UNSIGNED)
 
BEGIN
            INSERT INTO Cliente ( nombre, apellido, email, contraseña,idUsuario )
                        VALUES (unNombre, unApellido ,unEmail ,SHA2 (unaContraseña,256) , unidUsuario);
END$$

			
-- 3) Se pide hacer el SF ‘CantidadReproduccionesBanda’ que reciba por parámetro un identificador de banda y 2 fechas,se debe devolver la cantidad de reproducciones que tuvieron las canciones de esa banda entre esas 2 fechas (inclusive).
 
 
DELIMITER $$
DROP FUNCTION IF EXISTS CantidadReproduccionesBanda $$
 
CREATE FUNCTION CantidadReproduccionesBanda (IN unidBanda SMALLINT UNSIGNED , unInicio DATETIME , unFin  DATETIME)
                                                RETURNS DATETIME read sql data
 
BEGIN
        DECLARE resultado DATETIME;
 
       
        SELECT COUNT(*) INTO resultado
        FROM Reproduccion
        INNER JOIN Cancion USING(idCancion)
        INNER JOIN Album USING(idAlbum)
        WHERE reproduccion BETWEEN unInicio and unFin
 
        RETURN resultado ;
 
END

-- 4) Se pide hacer el SP ‘Buscar’ que reciba por parámetro una cadena. El SP tiene que devolver las canciones que contengan la cadena en su título, nombre de álbum o nombre de banda

DELIMITER $$
DROP PROCEDURE IF EXISTS Buscar $$
 
CREATE PROCEDURE Buscar (cadena VARCHAR(45))

 
BEGIN
        SELECT 
 
