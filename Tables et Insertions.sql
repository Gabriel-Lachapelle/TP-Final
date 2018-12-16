-- Suppresion des tables:
DROP TABLE Circuits CASCADE CONSTRAINTS;
DROP TABLE Monuments CASCADE CONSTRAINTS;
DROP TABLE Villes CASCADE CONSTRAINTS;
DROP TABLE Reservations CASCADE CONSTRAINTS;
DROP TABLE Clients CASCADE CONSTRAINTS;
DROP TABLE ListeMonuments CASCADE CONSTRAINTS;

-- Création des tables:
create table Monuments
(
  NumMonument number(3) constraint PK_Monuments primary key,
  NomMonument varchar2(60) not null,
  AnneeConstruction number(4),
  Histoire varchar2(600),
  Image varchar2(80) default 'vide',
  Prix number(5,2),
  NombreEtoiles number(1),
  constraint NombreEtoilesValide check (NombreEtoiles > 0 and NombreEtoiles <= 5),
  constraint PrixValide check (Prix >= 0)
);

create table Villes
(
  CodeVille char(3) CONSTRAINT PK_Ville PRIMARY KEY,
  NomVille varchar2(30),
  Habitants number(7),
  Histoire varchar2(600)
);

create table Circuits
(
  NumCircuit number(3) constraint PK_Circuits primary key, --Séquentiel
  VilleDepart char(3),
  VilleArrivee char(3),
  NomCircuit varchar2(60) constraint NomUnique unique,
  Prix number(7,2),
  Duree number(4),
  NombreClientsMax number(3),
  CONSTRAINT FKVilleDepart FOREIGN KEY(VilleDepart) REFERENCES Villes(CodeVille),
  CONSTRAINT FKVilleArrivee FOREIGN KEY(VilleArrivee) REFERENCES Villes(CodeVille),
  CONSTRAINT PrixCircuitValide CHECK (Prix >= 50),
  CONSTRAINT DureeValide CHECK (Duree >= 0),
  CONSTRAINT NombreClientValide CHECK (NombreClientsMax >= 0)
  );

create table Reservations
(
  NumReservation NUMBER CONSTRAINT PK_Reservation PRIMARY KEY, --Séquentiel
  NumCircuit number(3),
  DateReservation date,
  DateAnnulation date,
  constraint FK_Circuit foreign key(NumCircuit) references Circuits(NumCircuit)
);

create table Clients
(
     NumClient Number(3) CONSTRAINT PKClient PRIMARY KEY,
     NomClient varchar(30) constraint NomNonVide not null,
     NumTelephone varchar(20),
     NumReservation number,
     constraint FK_Reservation foreign key(NumReservation) references Reservations(NumReservation)
);

CREATE TABLE ListeMonuments (
    NumCircuit Number(3),
    NumMonument Number(3),
    Ordre Number(2),
    CONSTRAINT PK_ListeMonument PRIMARY KEY(NumCircuit, NumMonument),
    CONSTRAINT FK_Circuits FOREIGN KEY(NumCircuit) REFERENCES Circuits(NumCircuit),
    CONSTRAINT FK_Monument FOREIGN KEY(NumMonument) REFERENCES Monuments(NumMonument)
);

-- Suppression des séquences et vues:
DROP SEQUENCE ReservationSeq;
DROP SEQUENCE MonumentSeq;
DROP SEQUENCE CircuitSeq;
DROP SEQUENCE ClientSeq;
DROP VIEW TousLesCircuits;
DROP VIEW MeilleurCircuit;
DROP VIEW RechercheCircuit;
DROP VIEW ListeMonument;
DROP VIEW MonumentsCircuit;

-- Sequences:
CREATE SEQUENCE ReservationSeq INCREMENT BY 1 START WITH 1;
CREATE SEQUENCE MonumentSeq INCREMENT BY 1 START WITH 1;
CREATE SEQUENCE CircuitSeq INCREMENT BY 1 START WITH 1;
CREATE SEQUENCE ClientSeq INCREMENT BY 1 START WITH 1;

-- Vues:
create view TousLesCircuits as
select Circuits.NomCircuit, VilleDepart, VilleArrivee, Circuits.Prix, sum(NombreEtoiles) as TotalEtoiles from Circuits
left outer join ListeMonuments on Circuits.NumCircuit = ListeMonuments.NumCircuit
left outer join Monuments on ListeMonuments.NumMonument = Monuments.NumMonument
group by Circuits.NomCircuit, VilleDepart, VilleArrivee, Circuits.Prix
order by TotalEtoiles desc;

create view RechercheCircuit as
select Circuits.NomCircuit, VilleDepart, VilleArrivee, Circuits.Prix, NomMonument from Circuits
left outer join ListeMonuments on Circuits.NumCircuit = ListeMonuments.NumCircuit
left outer join Monuments on ListeMonuments.NumMonument = Monuments.NumMonument;

create view ListeMonument as
select Image, NomMonument, Monuments.Prix, Histoire, NomCircuit, Ordre from Monuments
inner join ListeMonuments on Monuments.NumMonument = ListeMonuments.NumMonument
inner join Circuits on Circuits.NumCircuit = ListeMonuments.NumCircuit;

create view MonumentsCircuit as
select NomMonument, NomCircuit, Ordre from Circuits
inner join ListeMonuments on Circuits.NumCircuit = ListeMonuments.NumCircuit
inner join Monuments on ListeMonuments.NumMonument = Monuments.NumMonument;

-- Monuments
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Le château Frontenac', 1893, 'Le Château Frontenac est le premier d''une longue série d''hôtels de style « château » construits par les compagnies ferroviaires canadiennes à la fin du XIXe et au début du XXe siècle', 
                                '8f7d79d6-38a6-4ab5-95bb-aadc01a5b5fb', 500, 4);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Le Rocher Percé', 1600, 'Le Rocher Percé est un îlot rocheux aux falaises escarpées possédant une arche naturelle et spectaculaire',
                                '45602779-dcfb-49e0-94d5-1d33c7253c6e', 200, 5);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Basilique Notre-Dame de Montréal', 1982, 'La basilique Notre-Dame de Montréal, sise dans l''arrondissement de Ville-Marie à Montréal, est l''église-mère de Montréal, la plus vaste de l''Archidiocèse de Montréal et la deuxième plus grande église de Montréal. Véritable galerie d''art religieux, elle abrite des ornements dont la richesse n''a pas d''équivalent à Montréal. ',
                                '0324d75b-f216-411c-8168-80ff36fbda87', 75, 3);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Jardin botanique de Montréal', 1931, 'Le Jardin botanique de Montréal est situé dans l''est de la ville de Montréal au Québec (Canada) et il est l''un des plus importants jardins botaniques du monde1.',
                                '8853428c-0b9a-4f14-8a64-408a82d9d375', 90, 3);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Marché Jean-Talon', 1929, 'Le marché Jean-Talon est un marché public au centre de la Petite Italie de Montréal.',
                                'f01dd135-a648-47ec-9980-7a14d104cd5b', 50, 1);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Parc national d`Oka', 1990, 'Le parc national d''Oka est un parc national du Québec (Canada) situé près du village d''Oka, sur la rive nord du lac des Deux Montagnes.', 
                                'f94a06e9-50d7-42cb-99a8-591201c4c2f4', 60, 2);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Super Aqua Club', 1985, 'En opération pendant les 10 semaines de l''été et avec plus de 45 attractions pour toute la famille, le Super Aqua Club est un parc aquatique complet qui accueille plusieurs milliers de visiteurs, chaque jour.', 
                                '6a086ea3-5d88-4dd6-ad20-8af15722bfa0', 100, 3);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Parc Michel-Chartrand', 1975, 'Le parc Michel-Chartrand, anciennement connu sous le nom de Parc régional de Longueuil, est un grand parc situé à Longueuil, au Québec, au Canada.', 
                                '95dccc75-80bb-4fca-8e10-64d0c3c58d62', 75, 2);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Chapelle des Indiens', 1750, 'La chapelle des Indiens est l''une des plus anciennes églises en bois en Amérique du Nord.',
                                'af554afd-3354-4fbd-961f-7408e4e8a6c4', 50, 4);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Hôtel du Parlement du Québec', 1886, 'L''hôtel du Parlement du Québec1 est l''édifice abritant l''Assemblée nationale du Québec.',
                                'f237a6c8-984c-42bc-b813-9bf56f087e6f', 150, 5);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Parc national du Fjord-du-Saguenay', 1983, 'Le parc national du Fjord-du-Saguenay, d''une superficie de 326,7 km2, est un parc national du Québec situé à une centaine de kilomètres en aval de Saguenay sur la rivière du même nom.', 
                                'a02bbdd1-05ce-4d90-91c6-bf8f409d96a1', 200, 4);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Centre d`interprétation des mammifères marins', 1991, 'Créé en 1991 par le Groupe de recherche et d''éducation sur les mammifères marins (GREMM), il est dédié à la recherche scientifique sur les baleines du Saint-Laurent. ', 
                                'fc396058-3ec9-4070-9c0e-88f1e1f4a8ec', 75, 2);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Musée Beaulne', 1976, 'Le musée Beaulne, ouvert en 1976 est un musée situé à Coaticook, en Estrie, au Québec. Il est situé dans une grande maison de Style Queen Anne nommé château Arthur-Osmore-Norton.', 
                                '27c1884e-54df-44bb-a3d7-651a4fcab24b', 50, 1);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Musée minéralogique et minier de Thetford Mines', 1976, 'Le musée a été fondé par la Société minéralogique de la région de L''Amiante (SOMIRA), lors du centenaire de la découverte de l''amiante.', 
                                '5f2d4bf4-615f-4079-9167-fbd20f853d0c', 150, 4);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'La Centrale de Beauharnois', 1961, 'La centrale de Beauharnois est une centrale hydroélectrique au fil de l''eau construite sur le Canal de Beauharnois, dans le secteur Melocheville de la Ville de Beauharnois', 
                                '4351eb5e-b395-4035-80d7-dbf11b3f6a3e', 120, 3);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Musée de la civilisation', 1988, 'Le musée présente des expositions thématiques temporaires et des permanentes ayant pour la plupart un lien avec les sciences humaines et sociales. Il est doté d''un important fonds d''objets d''intérêt ethnographique et historique. Il offre des visites guidées, des expositions interactives, un restaurant, un salon de détente et des spectacles.', 
                                '52d11157-3a2f-4466-b6da-01951e1ea4e7', 200, 5);
-- Villes
INSERT INTO Villes VALUES ('MTL', 'Montréal', 1705000, 'Montréal est la deuxième ville la plus peuplée du Canada. Elle se situe principalement sur l''île fluviale de Montréal, sur le fleuve Saint-Laurent (entre Québec et le lac Ontario) dans le Sud de la province de Québec, dont elle est la métropole.');
INSERT INTO Villes VALUES ('QBC', 'Québec', 531902, 'Québec est la capitale nationale du Québec6, une des provinces du Canada. Située au coeur de la région administrative de la Capitale-Nationale, elle est le siège de nombreuses institutions dont le Parlement du Québec');
INSERT INTO Villes VALUES ('PRC', 'Percé', 3103, 'Percé est une ville du Québec (au Canada) située à la pointe de la péninsule gaspésienne en face du célèbre rocher Percé et de l''île Bonaventure.');
INSERT INTO Villes VALUES ('OKA', 'Oka', 3824, 'Oka est une municipalité du Québec située dans la municipalité régionale de comté de Deux-Montagnes dans la région des Laurentides.');
INSERT INTO Villes VALUES ('POC', 'Pointe-Calumet', 6428, 'Pointe-Calumet est une municipalité d''environ 7 000 habitants, située dans la municipalité régionale de comté de Deux-Montagnes au Québec (Canada), région administrative des Laurentides.');
INSERT INTO Villes VALUES ('LON', 'Longueuil', 246899, 'Longueuil est une ville du Québec, au Canada, située sur la rive sud du fleuve Saint-Laurent, face à Montréal. Elle forme le coeur de l''agglomération de Longueuil, le secteur le plus urbanisé de la région de la Montérégie et de la banlieue sud de Montréal.');
INSERT INTO Villes VALUES ('TAD', 'Tadoussac', 600, 'Tadoussac est un village canadien qui fait partie de la municipalité régionale de comté (MRC) de La Haute-Côte-Nord dans la région administrative de la Côte-Nord au Québec. Il est situé au bord du fleuve Saint-Laurent. Tadoussac est le premier établissement français en Amérique du Nord situé au nord de la Floride française.');
INSERT INTO Villes VALUES ('SAG', 'Saguenay', 145949, 'Saguenay est une ville du Saguenay-Lac-Saint-Jean au Québec. Située dans une vallée aux abords de la rivière Saguenay, elle est en amont du fjord du Saguenay et en aval du horst de Kénogami. Du nord au sud, elle s''étend de la rive nord du Saguenay au massif des Laurentides. Sa superficie totale est de 1 136 km2.');
INSERT INTO Villes VALUES ('COA', 'Coaticook', 9183, 'Elle est surtout connue pour sa gorge et son pont suspendu pour piétons, cru le plus long au monde durant plusieurs années avant de voir son record « fracassé ». Au même moment, le parc de la gorge s''est modernisé, rénovant presque entièrement ses sentiers et annonçant l''ouverture de nouveaux sentiers nocturnes.');
INSERT INTO Villes VALUES ('THM', 'Thetford Mines', 25649, 'Thetford Mines est une ville du Québec, au Canada, située dans la municipalité régionale de comté des Appalaches en Chaudière-Appalaches.');
INSERT INTO Villes VALUES ('BHN', 'Beauharnois', 12011, 'Beauharnois est une ville de la municipalité régionale de comté de Beauharnois-Salaberry située au pays du Suroît au Québec. Beauharnois fait partie de la région administrative de la Montérégie et également partie de la Communauté métropolitaine de Montréal.');

-- Circuits
INSERT INTO Circuits VALUES(CircuitSeq.nextval, 'COA', 'PRC', 'Circuit De sud en est', 680, 4, 20);
INSERT INTO Circuits VALUES(CircuitSeq.nextval, 'MTL', 'SAG', 'Circuit Découverte Fleuve et Saguenay', 570, 5, 13);
INSERT INTO Circuits VALUES(CircuitSeq.nextval, 'OKA', 'MTL', 'Circuit Montréal et les alentours', 410, 2, 18);
INSERT INTO Circuits VALUES(CircuitSeq.nextval, 'PRC', 'OKA', 'Circuit Découverte sud Québec', 580, 4, 10);
INSERT INTO Circuits VALUES(CircuitSeq.nextval, 'PRC', 'MTL', 'Circuit Découvert Québec', 1000, 5, 5);

-- ListeMonuments
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Musée Beaulne'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Musée minéralogique et minier de Thetford Mines'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Musée de la civilisation'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Centre d`interprétation des mammifères marins'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Le Rocher Percé'), 5);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Basilique Notre-Dame de Montréal'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Jardin botanique de Montréal'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Hôtel du Parlement du Québec'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Chapelle des Indiens'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc national du Fjord-du-Saguenay'), 5);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montréal et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc national d`Oka'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montréal et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Super Aqua Club'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montréal et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc Michel-Chartrand'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montréal et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='La Centrale de Beauharnois'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montréal et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Marché Jean-Talon'), 5);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte sud Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Le Rocher Percé'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte sud Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Musée minéralogique et minier de Thetford Mines'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte sud Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc Michel-Chartrand'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte sud Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Jardin botanique de Montréal'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte sud Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc national d`Oka'), 5);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découvert Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Le Rocher Percé'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découvert Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Chapelle des Indiens'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découvert Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Le château Frontenac'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découvert Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Musée de la civilisation'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découvert Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Marché Jean-Talon'), 5);

COMMIT;

