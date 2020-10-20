
use Ministerio_MeioAmbiente

/*Inserções*/

INSERT INTO Usuario VALUES ('010101','Adrianne Sousa','11-982828282','3','Adrianne','123456')


select * from Usuario

INSERT INTO Estado VALUES 
('Acre', 'AC'),
('Alagoas', 'AL'),
('Amapá', 'AP'),
('Amazonas','AM'),
('Bahia', 'BA'),
('Ceará', 'CE'),
('Distrito federal','DF'),
('Espirito santo', 'ES'),
('Goiás','GO'),
('Maranhão', 'MA'),
('Mato Grosso','MT'),
('Mato Grosso do Sul','MS'),
('Minas Gerais', 'MG'),
('Pará', 'PA'),
('Paraíba', 'PB'),
('Paraná', 'PR'),
('Pernambuco','PE'),
('Piauí', 'PI'),
('Rio de janeiro','RJ'),
('Rio Grande do Norte', 'RN'),
('Rio Grande do Sul', 'RS'),
('Rondônia','RO'),
('Roraima', 'RR'),
('Santa Catarina', 'SC'),
('São Paulo','SP'),
('Sergipe','SE'),
('Tocantins','TO');


select * from Estado

INSERT INTO Cidade VALUES 
('Rio Branco',1),
('Maceió',2),
('Macapá',3),
('Manaus',4),
('Salvador',5),
('Fortaleza',6),
('Brasília',7),
('Vitória',8),
('Goiânia',9),
('São Luís',10),
('Cuiabá',11),
('Campo Grande',12),
('Belo Horizonte',13),
('Belém',14),
('João Pessoa',15),
('Curitiba',16),
('Recife',17),
('Teresina',18),
('Rio de Janeiro',19),
('Natal',20),
('Porto Alegre',21),
('Porto Velho',22),
('Boa Vista',23),
('Florianópolis',24),
('São Paulo',25),
('Aracaju',26),
('Palmas',27);

select * from Cidade

INSERT INTO Proprietario VALUES
/*('Caio Alvares Santos', 'caiosantos@gmail.com', '1199433296', '48875885937', '156874264'),*/
('Alfredo Neves Oliveira', 'alfredonoliv@gmail.com', '1775688422', '75824658924', '458852569'),
('João da Silva Pereira', 'jsp02@hotmail.com', '1147576698', '45871236548', '142558474'),
('Paulo Fagundes Filho', 'pauloff@gmail.com', '1058465514', '47856985478', '123654789'),
('Cleber Sousa de Paula','cleberspaula@hotmail.com', '11456937', '12365478965', '123456789'),
('Adrianne Oliveira', 'adrihsoliveira@gmail.com', '1254889696', '79461346749', '987654321'),
('Johnny Samir', 'joaosamir@hotmail.com', '1478523698', '79654125896', '159753654'),
('Alan Queiroz','alanqa@gmail.com', '1478745625', '14589652148', '164379465'),
('Clarissa Monte Beller','clarissamont@hotmail.com', '1125854445', '45632178965', '158742569'),
('Rafael Smith', 'rafaelsmith2@hotmail.com', '1147854436', '47859632145', '417452856'),
('Logan Estalon Santos', 'loganlestalon@gmail.com', '1365987444', '13467964316', '742585367'),
('Simal Gonzalo','ssmal@hotmail.com', '1454868686', '44477785698', '414414114'),
('Carlos Otto de Andrade', 'ottoandrade@gmail.com', '1545458787', '11155599987', '461379974'),
('Paulo Drummond', 'drummondp14@hotmail.com', '1050068874', '77785412559', '718293939'),
('Rubens Lindogan', 'ruqao@gmail.com', '1054878754', '98732145698', '464646464'),
('Adamastor Pereira Neto', 'adamastor@hotmail.com', '1145896325', '15975369874', '717171717'),
('Robson Santos Silva', 'robsonss@hotmail.com', '1687542132', '47896541236', '151515154'),
('Ednaldo Pereira Ademilson', 'ednaldoadm@hotmail.com', '1789784565', '14785236985', '784512547'),
('João Paulo Freire Neto', 'joaozinhopfn@hotmail.com', '1645874123', '14785236547', '784545454'),
('Matheus Komoras', 'matkomoras@hotmail.com', '1789654123', '14253669584', '454545454');

select * from Proprietario



/*INSERÇÃO NÃO FEITA AINDA. ESTÁ INCOMPLETA
cnpj,nome, endereço, id cidade, tamanho, produção, id proprietario*/
INSERT INTO Propriedade VALUES
/*('45758524589650', 'nome', 'Travessa osvaldo cruz, 37',25,'1000 Hectares','Tomate',3),*/
('45758524589651', 'nome', 'Rua pedro dias de amaral, 52',2,'5930 Hectares','Banana',4),
('45758524589652', 'nome', 'Estrada da sé, 21',6,'1578 Hectares','Melancia',5),
('45758524589653', 'nome', 'Rua maranhão dias, 33',14,'672 Hectares','Algodão',6),
('45758524589654', 'nome', 'Avenida paulo freire camões, 12',23,'476 Hectares','Milho',7),
('45758524589655', 'nome', 'Rua das nuvens, 27',9,'755 Hectares','Trigo',8),
('45758524589656', 'nome', 'Rua fernão diaz, 32',11,'582 Hectares','Milho',9),
('45758524589657', 'nome', 'Travessa pedro diniz, 29',24,'3556 Hectares','Seringueiras',10),
('45758524589658', 'nome', 'Estrada da serra florida, 20',10,'782 Hectares','Cenoura',11),
('45758524589659', 'nome', 'Rua freira amada, 31',15,'1600 Hectares','Abacaxi',12),
('45758524589661', 'nome', 'Rua presidente eleutério, 29',5,'1500 Hectares','Cana',16),
('45758524589662', 'nome', 'Rua dos pássaros azuis, 10',13,'1239 Hectares','Melão',17),
('45758524589663', 'nome', 'Avenida joão batista domingues, 107',22,'129 Hectares','Alface',18),
('45758524589664', 'nome', 'Avenida casa blanca, 1962',24,'203 Hectares','Flores',19),
('45758524589665', 'nome', 'Avenida casa blanca, 1992',24,'932 Hectares','Melancia',20),
('45758524589660', 'nome', 'Travessa Paulino Arnaldo Adolfo, 50',1,'500 Hectares','Batata',21),
('45758524589667', 'nome', 'Avenida do Estado, 1902',27,'14000 Hectares','Eucalipto',22),
('45758524589668', 'nome', 'Avenida Paulista, 1562',17,'1400 Hectares','Cana',13),
('45758524589669', 'nome', 'Estrada Garoto, 55',20,'3200 Hectares','Algodão',14);
