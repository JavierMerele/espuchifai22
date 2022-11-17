SELECT 'dump' Estado;
USE Espuchifai;

CALL altaBanda ('ACDC', '1978', @idAcDC);

CALL altaAlbum ('Back in Black', '1980-09-25', @idAcDC, @idBlackinBlack);

CALL altaAlbum ('powerage', '1978-05-05', @idAcDC, @idPowerage);

CALL altaCancion ('Hells Bells', 1, @idBlackinBlack, @idHellsBells);

CALL altaCancion ('Shoot to trill', 2, @idBlackinBlack, @idShoottotrill);

CALL altaCancion ('What do you for monney honey', 3, @idBlackinBlack, @idWhatdoyouformonneyhoney);

CALL altaCancion ('Rock Roll Damnation ', 1, @idPowerage, @idRockRollDamnation);

CALL altaCancion ('Down Payment Blues', 2, @idPowerage, @DownPaymentBlues);

CALL altaCancion ('Gimme a Bullet', 3, @idPowerage, @GimmeaBullet);

CALL
    registrarCliente(
        'Valentina',
        'Gutierrez',
        'gutierreez01@gmail.com',
        'Estrellas28',
        58
    );

CALL Reproducir (now(), @idWhatdoyouformonneyhoney, 58);

CALL Reproducir (now(),@idRockRollDamnation,58);

CALL Reproducir (now(),@GimmeaBullet,58);