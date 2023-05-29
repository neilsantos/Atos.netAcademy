--1. Relacione as entidades e seus respectivos atributos para este banco de dados;

--2. Crie o modelo conceitual desde banco de dados;

--3. Crie o modelo lógico deste banco de dados;

--4. Crie o comando SQL para a criação do banco de dados DINOSSAUROS;
CREATE DATABASE DINOSSAUROS

--5. Crie o comando SQL para a criação das tabelas solicitadas;

CREATE TABLE GRUPO
(
ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
NOME VARCHAR(50)
);

CREATE TABLE ERA
(
ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
NOME VARCHAR(50),
INICIO_DA_ERA INT,
FIM_DA_ERA INT,
);

CREATE TABLE DESCOBRIDOR
(
ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
NOME VARCHAR(50)
);

CREATE TABLE DINOSSAURO
(
ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
NOME VARCHAR(50),
PESO INT,
ANO_DESCOBERA INT,
PAIS VARCHAR(50),

FK_GRUPO INTEGER NOT NULL,
FK_ERA INTEGER NOT NULL,
FK_DESCOBRIDOR INTEGER NOT NULL,

FOREIGN KEY (FK_GRUPO) REFERENCES GRUPO(ID),
FOREIGN KEY (FK_ERA) REFERENCES ERA(ID),
FOREIGN KEY (FK_DESCOBRIDOR) REFERENCES DESCOBRIDOR(ID),
);




--6. Crie o comando SQL para inserção de pelo menos 3 registros acima, em todas as tabelas necessárias;



--7. Crie uma consulta para relacionar todos os dados disponíveis de todos os dinossauros existentes na catálogo em ordem alfabética de nome;

--8. Crie uma consulta para relacionar todos os dados disponíveis de todos os dinossauros existentes em ordem alfabética

--de Descobridor,

--9. Crie uma consulta para relacionar todos os dados disponíveis dos dinossauros do grupo anquilossauros em ordem de ano de descoberta;

--10. Crie uma consulta para relacionar todos os dados disponíveis dos dinossauros Ceratopsideos ou anquilossauros com ano de descoberta entre 1900 e 1999.

