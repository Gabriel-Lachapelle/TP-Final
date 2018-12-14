DROP TABLE Circuits CASCADE CONSTRAINTS;
DROP TABLE Monuments CASCADE CONSTRAINTS;
DROP TABLE Villes CASCADE CONSTRAINTS;
DROP TABLE Reservation CASCADE CONSTRAINTS;
DROP TABLE Clients CASCADE CONSTRAINTS;
DROP TABLE ListeMonuments CASCADE CONSTRAINTS;

create table Monuments
(
  NumMonument number(3) constraint PK_Monuments primary key,
  NomMonument varchar2(60),
  AnneeConstruction number(4),
  Histoire varchar2(600),
  Image varchar2(30),
  Prix number(5,2),
  NombreEtoiles number(1),
  constraint NombreEtoilesValide check (NombreEtoiles > 0 and NombreEtoiles <= 5)
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
  Prix number(4),
  Duree number(4),
  NombreClientsMax number(3),
  CONSTRAINT FKVilleDepart FOREIGN KEY(VilleDepart) REFERENCES Villes(CodeVille),
  CONSTRAINT FKVilleArrivee FOREIGN KEY(VilleArrivee) REFERENCES Villes(CodeVille)
  );

create table Reservation
(
  NumReservation NUMBER CONSTRAINT PK_Reservation PRIMARY KEY, --Séquentiel
  DateReservation date,
  DateAnnulation date
);

create table Clients
(
     NumClient Number(3) CONSTRAINT PKClient PRIMARY KEY
);

CREATE TABLE ListeMonuments (
    NumCircuit Number(3),
    NumMonument Number(3),
    Ordre Number(2),
    CONSTRAINT PK_ListeMonument PRIMARY KEY(NumCircuit, NumMonument),
    CONSTRAINT FK_Circuit FOREIGN KEY(NumCircuit) REFERENCES Circuits(NumCircuit),
    CONSTRAINT FK_Monument FOREIGN KEY(NumMonument) REFERENCES Monuments(NumMonument)
);