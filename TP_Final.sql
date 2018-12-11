create table Circuits
(
  NumCircuit number(3) constraint PK_Circuits primary key, --Séquentiel
  NomCircuit varchar2(30),
  VilleDepart varchar2(30),
  VilleArrivee varchar2(30),
  Prix number(4,2),
  Duree number(4),
  NombreClientsMax number(3)
  constraint NomUnique unique
);

create table Monuments
(
  NumMonument number(3) constraint PK_Monuments primary key,
  NomMonument varchar2(30),
  DateConstruction date,
  Histoire varchar(60),
  Image varchar2(30),
  Prix number(4,2),
  NombreEtoiles number(1),
  constraint NombreEtoilesValide check (NombreEtoiles > 0 and NombreEtoiles <= 5)
);

create table Villes
(
  CodeVille char(3),
  NomVille varchar2(30),
  Habitants number(7),
  Histoire varchar2(60)
);

create table Reservation
(
  NumReservation, --Séquentiel
  DateReservation date,
  DateAnnulation date
);

create table Clients
(
  NumClient
);
