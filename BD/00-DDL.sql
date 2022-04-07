DROP DATABASE IF EXISTS Espuchifai;
CREATE DATABASE Espuchifai;

CREATE TABLE Espuchifai.Banda(
    nombre VARCHAR(45)   NOT NULL,
    fundacion YEAR NOT NULL,
    idBanda SMALLINT UNSIGNED NOT NULL,
    PRIMARY KEY(idBanda)
);
CREATE TABLE Espuchifai.Usuario(
    nombre VARCHAR (45) NOT NULL,
    apellido VARCHAR (45) NOT NULL,
    email VARCHAR (45) NOT NULL,
    contraseña CHAR (64) NOT NULL,
    idUsuario SMALLINT UNSIGNED NOT NULL,
    PRIMARY KEY (idUsuario)
);

CREATE TABLE Espuchifai.Album(
    nombre VARCHAR(45) NOT NULL,
    lanzamiento DATE NOT NULL,
    idBanda SMALLINT UNSIGNED NOT NULL,
    idAlbum SMALLINT UNSIGNED NOT NULL,
    PRIMARY KEY (idAlbum),
    CONSTRAINT FK_Album_banda FOREIGN KEY (idBanda)
        REFERENCES Espuchifai.banda (idBanda),
    CONSTRAINT UQ_Album_nombre UNIQUE (nombre)
);
CREATE TABLE Espuchifai.Cancion (
    nombre VARCHAR(45) NOT NULL,
    orden TINYINT UNSIGNED NOT NULL,
    idAlbum SMALLINT UNSIGNED NOT NULL,
    idCancion SMALLINT UNSIGNED NOT NULL,
    PRIMARY KEY (idCancion),
    CONSTRAINT FK_Cancion_Album FOREIGN KEY(idAlbum)
        REFERENCES Espuchifai.Album (idAlbum),
    CONSTRAINT UQ_Cancion_nombre UNIQUE (nombre)
);

CREATE TABLE Espuchifai.Reproduccion(
    reproduccion DATETIME NOT NULL,
    idCancion SMALLINT UNSIGNED NOT NULL,
    idUsuario  SMALLINT UNSIGNED NOT NULL,
    PRIMARY KEY (reproduccion,idCancion,idUsuario),
    CONSTRAINT FK_Reproduccion_Cancion FOREIGN KEY (idCancion)
        REFERENCES Espuchifai.Cancion (idCancion),
    CONSTRAINT FK_Reproduccion_Usuario FOREIGN KEY  (idUsuario)
        REFERENCES Espuchifai.Usuario (idUsuario)
    );
