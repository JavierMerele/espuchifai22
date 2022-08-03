-- 1) Cada vez que se inserta una reproducción, se incrementa el contador de reproducciones de la canción en uno.

DELIMITER $$
CREATE TRIGGER AftInsReproduccion AFTER INSERT ON Reproduccion
FOR EACH ROW
BEGIN

    UPDATE Cancion
    SET cantidad = cantidad +1
    WHERE idCancion = new.idCancion ;

END $$

-- 2) Cada vez que se actualiza el contador de la canción en N reproducciones, se incrementa el contador del álbum también en N.

DELIMITER $$
CREATE TRIGGER AftUpdReproduccion  AFTER UPDATE Cancion
FOR EACH ROW
BEGIN
    IF (NEW.cantidad > OLD.cantidad) THEN
        UPDATE Album
        SET cantidad = cantidad +1
        WHERE idAlbum = new.idAlbum;

    END IF ;
END $$

