CREATE USER IF NOT EXISTS "Banda" @'%' IDENTIFIED BY 'manzana';

GRANT INSERT,SELECT ON Espuchifai.Banda TO "Banda" @'%';

GRANT INSERT,SELECT ON Espuchifai.Album TO "Banda" @'%';

GRANT INSERT,SELECT ON Espuchifai.Cancion TO "Banda" @'%';

CREATE USER IF NOT EXISTS "Usuario" @'%' IDENTIFIED BY 'manzana';

GRANT SELECT ON Espuchifai.* TO 'Usuario'@'%';

GRANT INSERT ON Espuchifai.Reproduccion TO 'Usuario'@'%';