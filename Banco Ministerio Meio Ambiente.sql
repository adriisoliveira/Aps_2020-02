create database Ministerio_MeioAmbiente

use Ministerio_MeioAmbiente


create table Usuario (
	ID_Usuario int primary key IDENTITY NOT NULL,
	Biometria varchar (255),
	Nome varchar (255),
	Telefone varchar (23),
	Tipo_Acesso int,
	Senha varchar (255)
);

create table Proprietario (
	ID_Proprietario int primary key IDENTITY NOT NULL,
	Nome_Proprietario varchar (255),
	Email_Proprietario varchar (255),
	Telefone_Proprierario varchar (23),
	CPF_Proprietario varchar (13),
	RG_Proprietario varchar (10)
);

CREATE TABLE Estado(
    ID_Estado INT NOT NULL PRIMARY KEY IDENTITY,
    Nome_Estado VARCHAR(255) NOT NULL,
    UF VARCHAR(3) NOT NULL
);

CREATE TABLE Cidade(
    ID_Cidade INT NOT NULL PRIMARY KEY IDENTITY,
    Nome_Cidade VARCHAR(255) NOT NULL,
    ID_Estado INT NOT NULL,
    FOREIGN KEY (ID_Estado) REFERENCES Estado(ID_Estado)
);

create table Propriedade (
	ID_Propriedade int primary key IDENTITY NOT NULL,
	CNPJ_Propriedade varchar (15),
	Nome varchar (255),
	Endereco varchar (255),
	ID_Cidade INT NOT NULL,
	ID_Proprietario INT NOT NULL,
	FOREIGN KEY (ID_Cidade) references Cidade (ID_Cidade),
	FOREIGN KEY (ID_Proprietario) references Proprietario (ID_Proprietario)
);


CREATE TABLE Agrotoxico(
    ID_Agrotoxico INT NOT NULL PRIMARY KEY IDENTITY,
    Nome_Agrotoxico VARCHAR(255) NOT NULL,
    Descricao TEXT,
    Composicao TEXT NOT NULL,
    Permissao INT NOT NULL
);

CREATE TABLE Agrotoxico_Propriedade(
    ID_Propriedade INT NOT NULL,
    ID_agrotoxico INT NOT NULL,
    inicio_uso DATE NOT NULL,
    fim_uso DATE,
    FOREIGN KEY (ID_Agrotoxico) REFERENCES agrotoxico(ID_Agrotoxico),
    FOREIGN KEY (ID_Propriedade) REFERENCES propriedade(ID_Propriedade)
);


