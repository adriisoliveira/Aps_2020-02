
create database Ministerio_MeioAmbiente
use Ministerio_MeioAmbiente

/*Inser��es*/

INSERT INTO Usuario VALUES ('010101','Adrianne Sousa','11-982828282','3','Adrianne','123456')


select * from Usuario

INSERT INTO Estado VALUES 
('Acre', 'AC'),
('Alagoas', 'AL'),
('Amap�', 'AP'),
('Amazonas','AM'),
('Bahia', 'BA'),
('Cear�', 'CE'),
('Distrito federal','DF'),
('Espirito santo', 'ES'),
('Goi�s','GO'),
('Maranh�o', 'MA'),
('Mato Grosso','MT'),
('Mato Grosso do Sul','MS'),
('Minas Gerais', 'MG'),
('Par�', 'PA'),
('Para�ba', 'PB'),
('Paran�', 'PR'),
('Pernambuco','PE'),
('Piau�', 'PI'),
('Rio de janeiro','RJ'),
('Rio Grande do Norte', 'RN'),
('Rio Grande do Sul', 'RS'),
('Rond�nia','RO'),
('Roraima', 'RR'),
('Santa Catarina', 'SC'),
('S�o Paulo','SP'),
('Sergipe','SE'),
('Tocantins','TO');


select * from Estado

INSERT INTO Cidade VALUES 
('Rio Branco','AC'),
('Macei�','AL'),
('Macap�','AP'),
('Manaus','AM'),
('Salvador','BA'),
('Fortaleza','CE'),
('Bras�lia','DF'),
('Vit�ria','ES'),
('Goi�nia','GO'),
('S�o Lu�s','MA'),
('Cuiab�','MT'),
('Campo Grande','MS'),
('Belo Horizonte','MG'),
('Bel�m','PA'),
('Jo�o Pessoa','PA'),
('Curitiba','PR'),
('Recife','PE'),
('Teresina','PI'),
('Rio de Janeiro','RJ'),
('Natal','RN'),
('Porto Alegre','RS'),
('Porto Velho','RO'),
('Boa Vista','RR'),
('Florian�polis','SC'),
('S�o Paulo','SP'),
('Aracaju','SE'),
('Palmas','TO'
);

select * from Cidade

INSERT INTO Proprietario VALUES ('Caio Alvares Santos', 'caiosantos@gmail.com', '1199433296', '48875885937', '156874264');

select * from Proprietario

INSERT INTO Proprietario VALUES
/*('Caio Alvares Santos', 'caiosantos@gmail.com', '1199433296', '48875885937', '156874264'),*/
/*('Alfredo Neves Oliveira', 'alfredonoliv@gmail.com', '1775688422', '75824658924', '458852569'),*/
('Jo�o da Silva Pereira','jsp02@hotmail.com', '1147576698', '45871236548', '142558474'),
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
('Jo�o Paulo Freire Neto', 'joaozinhopfn@hotmail.com', '1645874123', '14785236547', '784545454'),
('Matheus Komoras', 'matkomoras@hotmail.com', '1789654123', '14253669584', '454545454');

select * from Proprietario



/*INSER��O N�O FEITA AINDA. EST� INCOMPLETA
cnpj,nome, endere�o, id cidade, tamanho, produ��o, id proprietario*/
INSERT INTO Propriedade VALUES
/*('45758524589650', 'nome', 'Travessa osvaldo cruz, 37',25,'1000 Hectares','Tomate',3),*/
('45758524589651', 'Fazenda Matarazzo', 'Rua pedro dias de amaral, 52','Bel�m','5930 Hectares','Banana','14253669584'),
('45758524589652', 'Fazenda Dois Cora��es', 'Estrada da s�, 21','Campo Grande','1578 Hectares','Melancia','14589652148'),
('45758524589653', 'Fazenda Bom dia', 'Rua maranh�o dias, 33','Macei�','672 Hectares','Algod�o','14785236547'),
('45758524589654', 'Fazenda Sol nascente', 'Avenida paulo freire cam�es, 12','Salvador','476 Hectares','Milho','14785236985'),
('45758524589655', 'Fazenda Serra Prateada', 'Rua das nuvens, 27','Florian�polis','755 Hectares','Trigo','15975369874'),
('45758524589656', 'Fazenda Colina Esmeralda', 'Rua fern�o diaz, 32','Goi�nia','582 Hectares','Milho','44477785698'),
('45758524589657', 'Fazenda Penhasco de Diamante', 'Travessa pedro diniz, 29','Rio Branco','3556 Hectares','Seringueiras','45632178965'),
('45758524589658', 'Fazenda DaPrada', 'Estrada da serra florida, 20','Fortaleza','782 Hectares','Cenoura','45871236548'),
('45758524589659', 'Fazenda Vinho Branco', 'Rua freira amada, 31','Manaus','1600 Hectares','Abacaxi','47856985478'),
('45758524589661', 'Fazenda Solim�es', 'Rua presidente eleut�rio, 29','Bras�lia','1500 Hectares','Cana','77785412559'),
('45758524589662', 'Fazenda Rio Negro', 'Rua dos p�ssaros azuis, 10','Macap�','1239 Hectares','Mel�o','79461346749'),
('45758524589663', 'Fazenda Tiet�', 'Avenida jo�o batista domingues, 107','Rio de Janeiro','129 Hectares','Alface','79654125896'),
('45758524589664', 'Fazenda Chit�ozinho', 'Avenida casa blanca, 1962','S�o Lu�s','203 Hectares','Flores','98732145698'),
('45758524589665', 'Fazenda dos �nibus', 'Avenida casa blanca, 1992','S�o Lu�s','932 Hectares','Melancia','47859632145'),
('45758524589660', 'Fazenda Lojas Renner', 'Travessa Paulino Arnaldo Adolfo, 50','Aracaju','500 Hectares','Batata','47896541236')
/*('45758524589667', 'Fazenda M�oleve', 'Avenida do Estado, 1902','Vit�ria','14000 Hectares','Eucalipto','461379974'),
('45758524589668', 'Fazenda Habibs', 'Avenida Paulista, 1562','Palmas','1400 Hectares','Cana','417452856'),
('45758524589669', 'Fazenda FSmith', 'Estrada Garoto, 55','Recife','3200 Hectares','Algod�o','164379465')*/;


INSERT INTO Agrotoxico VALUES
('Glifosfato','Pode causar efeitos colaterais em humanos como:desordens gastrointestinais, obesidade, diabetes, doen�as card�acas, depress�o, autismo, infertilidade, c�ncer, mal de Alzheimer, mal de Parkinson, microcefalia, intoler�ncia ao gl�ten e altera��es hormonais','Herbicida','C3H8NO5P','gr�os, algod�o, cana, cereais, frutas, pastagens, fumo, eucalipto e seringueiras'),
/*('Atrazina','N�o detectados grandes efeitos colaterais em humanos','Herbicida','C8H14ClN5','gr�os, cereais, cana, eucalipto e pastagens'),*/
('Dicloredo de Paraquate','Pode causar efeitos colaterais em humanos como: necrose do mioc�rdio, necrose hep�tica periacinar, necrose dos t�bulos renais, necrose adrenocortical, necrose dose-dependente dos pneum�citos do tipo I e por congest�o, edema e hemorragia pulmonares','Herbicida','C12H14N2','gr�os, algod�o, cana, batata e frutas'),
('Diurom','Pode causar efeitos colaterais em humanos como:Irrita��o na pele, Irrita��o ocular','Herbicida','C9H10Cl2N2O','algod�o, gr�os, cana, eucaliptos e frutas'),
('Sulfentrazona','Pode causar efeitos colaterais em humanos como:N�usea, Dor de cabe�a, Nariz entupido, Dores musculares, Boca seca, Sudorese, Ins�nia, Sonol�ncia','Herbicida','C11H10Cl2F2N4O3S','algod�o, frutas, fumo, gr�os, cana e eucalipto'),
('Mancozebe','N�o identificado o efeito em humanos','Fungicida','C4H6MnN2S4','gr�os, frutas, hortali�as, legumes, cereais, fumo, seringueiras, flores, eucalipto e cana'),
/*('Piraclostrobina','Pode causar efeitos colaterais em humanos como: Interfer�ncia de fatores bi�ticos e abi�ticos na assimila��o de carbono e de nitrog�nio na fase reprodutiva dos gr�os','Fungicida','C19H18ClN3O4','algod�o, gr�os, flores, frutas, cereais, legumes, eucalipto, cana, pastagens e pupunha'),*/
('Protioconazol','N�o identificado o efeito em humanos','Fungicida','C14H15Cl2N3OS','algod�o, cereais, flores e gr�os'),
('Fluxapiroxade','Pode causar efeitos colaterais em humanos como: Redu��o da atividade das enzimas antioxidantes das plantas','Fungicida','C18H12F5N3O','algod�o, gr�os, cereais, flores, cana e legume'),
('Acefato','Pode causar efeitos colaterais em humanos como:neuropatias, altera��o da quantidade de s�men e o DNA na forma��o dos espermatozoides','Inseticida','C4H10NO3PS','algod�o, gr�os e frutasgr�os, frutas, legumes, hortali�as, pastagens, cana, eucalipto, fumo, cereais e flores')
/*('Imidacloprido','Pode causar efeitos colaterais em humanos como: Letargia, V�mito, Diarr�ia, Perda de apetite, Trope�o','Inseticida','C9H10ClN5O2','gr�os, frutas, legumes, hortali�as, pastagens, cana, eucalipto, fumo, cereais e flores')*/;


