USE master;
GO

DROP DATABASE BDPASTELARIA;
GO

CREATE DATABASE BDPASTELARIA;
GO

USE BDPASTELARIA;
GO

CREATE TABLE FUNCIONARIO (
	CODFUNCIONARIO INT NOT NULL PRIMARY KEY IDENTITY,
	NOME VARCHAR(50),
	FUNCAO VARCHAR(30),
	SALARIO MONEY,
	CELULAR CHAR(14)
);
GO

CREATE TABLE PRODUTO (
	CODPRODUTO INT NOT NULL PRIMARY KEY IDENTITY,
	NOMEPRODUTO VARCHAR(50) NOT NULL,
	QUANTIDADE INT,
	PRECO MONEY,
	OBS TEXT	 
);
GO

CREATE TABLE CLIENTE (
	CODCLIENTE INT NOT NULL PRIMARY KEY IDENTITY,
	NOME VARCHAR(50) NOT NULL,
	TELEFONE CHAR(13),
	CELULAR CHAR(14),
	EMAIL VARCHAR(50),
	ENDERECO VARCHAR(40),
	BAIRRO VARCHAR(30),
	CIDADE VARCHAR(50),
	NUMERO VARCHAR(5),
	CEP CHAR(9),
	REFERENCIA VARCHAR(100),
	CPF CHAR(14) UNIQUE NOT NULL
);
GO