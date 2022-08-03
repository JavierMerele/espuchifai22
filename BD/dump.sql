DELIMITER;
USE Espuchifai;
CALL altaBanda ('ACDC', '1978', 9);
CALL altaAlbum ('Back in Black', '1980-09-25', 9, 4);
CALL altaAlbum ('powerage', '1978-05-05', 9, 7);
CALL altaCancion ('Hells Bells', 1, 4, 10);
CALL altaCancion ('Shoot to trill', 2, 4, 11);
CALL altaCancion ('What do you for monney honey', 3, 4, 12);
CALL altaCancion ('Rock  Roll Damnation ', 1, 7, 13);
CALL altaCancion ('Down Payment Blues', 2, 7, 14);
CALL altaCancion ('Gimme a Bullet', 3, 7, 15);
CALL registrarCliente(
  'Valentina',
  'Gutierrez',
  'gutierreez01@gmail.com',
  'Estrellas28',
  58
);
CALL Reproducir (now(), 10, 58);
CALL Reproducir (now(),11,58);
CALL Reproducir (now(),15,58);
