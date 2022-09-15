CREATE USER IF NOT EXISTS "Banda" @'%' IDENTIFIED BY 'manzana';

GRANT INSERT,SELECT ON espuchifai22.Banda TO "Banda" @'%';
GRANT INSERT,SELECT ON espuchifai22.Album TO "Banda" @'%';
GRANT INSERT,SELECT ON espuchifai22.Cancion TO "Banda" @'%';


CREATE USER IF NOT EXISTS "Usuario" @'%' IDENTIFIED BY 'manzana';

GRANT SELECT ON espuchifai22.* TO 'Usuario'@'%';
GRANT INSERT ON espuchifai22.Reproduccion TO 'Usuario'@'%';