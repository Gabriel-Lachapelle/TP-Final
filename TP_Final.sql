CREATE TABLE Circuits
  (
    NumCircuit       NUMBER (3) NOT NULL ,
    VilleDepart      CHAR (3) NOT NULL ,
    VilleArrivee     CHAR (3) NOT NULL ,
    NomCircuit       VARCHAR2 (30) ,
    Duree            NUMBER (5) ,
    Prix             NUMBER (5,2) ,
    NombreClientsMax NUMBER (3)
  ) ;
ALTER TABLE Circuits ADD CONSTRAINT Circuits_CK_1 CHECK (Prix >= 50) ;
ALTER TABLE Circuits ADD CONSTRAINT Circuits_PK PRIMARY KEY ( NumCircuit ) ;
ALTER TABLE Circuits ADD CONSTRAINT Circuits__UN UNIQUE ( NomCircuit ) ;


CREATE TABLE Clients
  (
    NumClient NUMBER (3) NOT NULL ,
    NomClient VARCHAR2 (30)
  ) ;
ALTER TABLE Clients ADD CONSTRAINT Clients_PK PRIMARY KEY ( NumClient ) ;


CREATE TABLE ListeMonuments
  (
    NumCircuit  NUMBER (3) NOT NULL ,
    NumMonument NUMBER (3) NOT NULL ,
    Ordre       NUMBER (2)
  ) ;
ALTER TABLE ListeMonuments ADD CONSTRAINT ListeMonuments_PK PRIMARY KEY ( NumMonument, NumCircuit ) ;


CREATE TABLE Monuments
  (
    Nom              VARCHAR2 (30) ,
    DateConstruction DATE ,
    Histoire         VARCHAR2 (50) ,
    URLImage         VARCHAR2 (30) ,
    Prix             NUMBER (5,2) ,
    NombreEtoiles    NUMBER (1) ,
    NumMonument      NUMBER (3) NOT NULL
  ) ;
ALTER TABLE Monuments ADD CONSTRAINT Monuments_CK_1 CHECK (NombreEtoiles > 0 AND NombreEtoiles <= 5) ;
ALTER TABLE Monuments ADD CONSTRAINT Monuments_PK PRIMARY KEY ( NumMonument ) ;


CREATE TABLE Reservations
  (
    NumReservation  NUMBER (3) NOT NULL ,
    DateReservation DATE ,
    DateLimite      DATE ,
    NumCircuit      NUMBER (3) NOT NULL
  ) ;
ALTER TABLE Reservations ADD CONSTRAINT Reservations_PK PRIMARY KEY ( NumReservation ) ;


CREATE TABLE Villes
  (
    CodeVille       CHAR (3) NOT NULL ,
    Nom             VARCHAR2 (30) ,
    NombreHabitants NUMBER (7) ,
    Histoire        VARCHAR2 (50)
  ) ;
ALTER TABLE Villes ADD CONSTRAINT Villes_PK PRIMARY KEY ( CodeVille ) ;

ALTER TABLE Circuits ADD CONSTRAINT Circuits_Villes_FK FOREIGN KEY ( VilleDepart ) REFERENCES Villes ( CodeVille ) ;

ALTER TABLE Circuits ADD CONSTRAINT Circuits_Villes_FKv2 FOREIGN KEY ( VilleArrivee ) REFERENCES Villes ( CodeVille ) ;

ALTER TABLE ListeMonuments ADD CONSTRAINT ListeMonuments_Circuits_FK FOREIGN KEY ( NumCircuit ) REFERENCES Circuits ( NumCircuit ) ;

ALTER TABLE ListeMonuments ADD CONSTRAINT ListeMonuments_Monuments_FK FOREIGN KEY ( NumMonument ) REFERENCES Monuments ( NumMonument ) ;

ALTER TABLE Reservations ADD CONSTRAINT Reservations_Circuits_FK FOREIGN KEY ( NumCircuit ) REFERENCES Circuits ( NumCircuit ) ;

ALTER TABLE Reservations ADD CONSTRAINT Reservations_Clients_FK FOREIGN KEY ( NumReservation ) REFERENCES Clients ( NumClient ) ;