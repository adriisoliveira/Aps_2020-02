create database Ministerio_MeioAmbiente

use Ministerio_MeioAmbiente


create table Usuario (
	ID_Usuario int primary key IDENTITY(1,1) NOT NULL,
	Biometria varchar (255),
	Nome varchar (255),
	Telefone varchar (23),
	Tipo_Acesso int,
	UsuarioLogin varchar (255),
	Senha varchar (255)
);

create table Proprietario (
	Nome_Proprietario varchar (255),
	Email_Proprietario varchar (255),
	Telefone_Proprierario varchar (23),
	CPF_Proprietario varchar(11) primary key NOT NULL,
	RG_Proprietario varchar (10)
);

CREATE TABLE Estado(
    Nome_Estado VARCHAR(255) NOT NULL,
	UF_Estado VARCHAR (2) NOT NULL PRIMARY KEY
);


CREATE TABLE Cidade(
    Nome_Cidade varchar (255) NOT NULL PRIMARY KEY,
    UF_Estado VARCHAR(2) NOT NULL,
    FOREIGN KEY (UF_Estado) REFERENCES Estado(UF_Estado)
);

create table Propriedade (
	ID_Propriedade int IDENTITY(1,1) NOT NULL,
	CNPJ_Propriedade varchar (15) primary key,
	Nome varchar (255),
	Endereco varchar (255),
	Nome_Cidade varchar(255) NOT NULL,
	Tamanho varchar(255),
	Producao varchar (255),
	CPF_Proprietario varchar (11) NOT NULL,
	FOREIGN KEY (Nome_Cidade) references Cidade (Nome_Cidade),
);


CREATE TABLE Agrotoxico(
    ID_Agrotoxico INT NOT NULL IDENTITY(1,1),
    Nome_Agrotoxico VARCHAR(255) PRIMARY KEY NOT NULL,
    Descricao TEXT,
	Classificacao TEXT NOT NULL,
    Composicao TEXT NOT NULL,
    Permissao VARCHAR (255) NOT NULL
);

CREATE TABLE Agrotoxico_Propriedade(
    CNPJ_Propriedade VARCHAR (15) NOT NULL,
    Nome_agrotoxico varchar(255) NOT NULL,
    inicio_uso DATE NOT NULL,
    fim_uso DATE,
    FOREIGN KEY (Nome_Agrotoxico) REFERENCES agrotoxico(Nome_Agrotoxico),
    FOREIGN KEY (CNPJ_Propriedade) REFERENCES propriedade(CNPJ_Propriedade)
);


drop table Agrotoxico_Propriedade
drop table Agrotoxico
drop table Propriedade
drop table Cidade
drop table Estado
drop table Proprietario