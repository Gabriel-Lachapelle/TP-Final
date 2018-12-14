-- S�quence
/*DROP SEQUENCE ReservationSeq;
DROP SEQUENCE MonumentSeq;
DROP SEQUENCE CircuitSeq;
DROP SEQUENCE ClientSeq;*/

CREATE SEQUENCE ReservationSeq INCREMENT BY 1 START WITH 1;
CREATE SEQUENCE MonumentSeq INCREMENT BY 1 START WITH 1;
CREATE SEQUENCE CircuitSeq INCREMENT BY 1 START WITH 1;
CREATE SEQUENCE ClientSeq INCREMENT BY 1 START WITH 1;

-- Monuments
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Le ch�teau Frontenac', 1893, 'Le Ch�teau Frontenac est le premier d''une longue s�rie d''h�tels de style � ch�teau � construits par les compagnies ferroviaires canadiennes � la fin du XIXe et au d�but du XXe si�cle', 
                                'vide', 500, 4);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Le Rocher Perc�', 1600, 'Le Rocher Perc� est un �lot rocheux aux falaises escarp�es poss�dant une arche naturelle et spectaculaire',
                                'vide', 200, 5);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Basilique Notre-Dame de Montr�al', 1982, 'La basilique Notre-Dame de Montr�al, sise dans l''arrondissement de Ville-Marie � Montr�al, est l''�glise-m�re de Montr�al, la plus vaste de l''Archidioc�se de Montr�al et la deuxi�me plus grande �glise de Montr�al. V�ritable galerie d''art religieux, elle abrite des ornements dont la richesse n''a pas d''�quivalent � Montr�al. ',
                                'vide', 75, 3);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Jardin botanique de Montr�al', 1931, 'Le Jardin botanique de Montr�al est situ� dans l''est de la ville de Montr�al au Qu�bec (Canada) et il est l''un des plus importants jardins botaniques du monde1.',
                                'vide', 90, 3);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'March� Jean-Talon', 1929, 'Le march� Jean-Talon est un march� public au centre de la Petite Italie de Montr�al.',
                                'vide', 50, 1);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Parc national d''Oka', 1990, 'Le parc national d''Oka est un parc national du Qu�bec (Canada) situ� pr�s du village d''Oka, sur la rive nord du lac des Deux Montagnes.', 
                                'vide', 60, 2);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Super Aqua Club', 1985, 'En op�ration pendant les 10 semaines de l''�t� et avec plus de 45 attractions pour toute la famille, le Super Aqua Club est un parc aquatique complet qui accueille plusieurs milliers de visiteurs, chaque jour.', 
                                'vide', 100, 3);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Parc Michel-Chartrand', 1975, 'Le parc Michel-Chartrand, anciennement connu sous le nom de Parc r�gional de Longueuil, est un grand parc situ� � Longueuil, au Qu�bec, au Canada.', 
                                'vide', 75, 2);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Chapelle des Indiens', 1750, 'La chapelle des Indiens est l''une des plus anciennes �glises en bois en Am�rique du Nord.',
                                'vide', 50, 4);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'H�tel du Parlement du Qu�bec', 1886, 'L''h�tel du Parlement du Qu�bec1 est l''�difice abritant l''Assembl�e nationale du Qu�bec.',
                                'vide', 150, 5);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Parc national du Fjord-du-Saguenay', 1983, 'Le parc national du Fjord-du-Saguenay, d''une superficie de 326,7 km2, est un parc national du Qu�bec situ� � une centaine de kilom�tres en aval de Saguenay sur la rivi�re du m�me nom.', 
                                'vide', 200, 4);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Centre d''interpr�tation des mammif�res marins', 1991, 'Cr�� en 1991 par le Groupe de recherche et d''�ducation sur les mammif�res marins (GREMM), il est d�di� � la recherche scientifique sur les baleines du Saint-Laurent. ', 
                                'vide', 75, 2);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Mus�e Beaulne', 1976, 'Le mus�e Beaulne, ouvert en 1976 est un mus�e situ� � Coaticook, en Estrie, au Qu�bec. Il est situ� dans une grande maison de Style Queen Anne nomm� ch�teau Arthur-Osmore-Norton.', 
                                'vide', 50, 1);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Mus�e min�ralogique et minier de Thetford Mines', 1976, 'Le mus�e a �t� fond� par la Soci�t� min�ralogique de la r�gion de L''Amiante (SOMIRA), lors du centenaire de la d�couverte de l''amiante.', 
                                'vide', 150, 4);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'La Centrale de Beauharnois', 1961, 'La centrale de Beauharnois est une centrale hydro�lectrique au fil de l''eau construite sur le Canal de Beauharnois, dans le secteur Melocheville de la Ville de Beauharnois', 
                                'vide', 120, 3);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Mus�e de la civilisation', 1988, 'Le mus�e pr�sente des expositions th�matiques temporaires et des permanentes ayant pour la plupart un lien avec les sciences humaines et sociales. Il est dot� d''un important fonds d''objets d''int�r�t ethnographique et historique. Il offre des visites guid�es, des expositions interactives, un restaurant, un salon de d�tente et des spectacles.', 
                                'vide', 200, 5);
-- Villes

INSERT INTO Villes VALUES ('MTL', 'Montr�al', 1705000, 'Montr�al est la deuxi�me ville la plus peupl�e du Canada. Elle se situe principalement sur l''�le fluviale de Montr�al, sur le fleuve Saint-Laurent (entre Qu�bec et le lac Ontario) dans le Sud de la province de Qu�bec, dont elle est la m�tropole.');
INSERT INTO Villes VALUES ('QBC', 'Qu�bec', 531902, 'Qu�bec est la capitale nationale du Qu�bec6, une des provinces du Canada. Situ�e au coeur de la r�gion administrative de la Capitale-Nationale, elle est le si�ge de nombreuses institutions dont le Parlement du Qu�bec');
INSERT INTO Villes VALUES ('PRC', 'Perc�', 3103, 'Perc� est une ville du Qu�bec (au Canada) situ�e � la pointe de la p�ninsule gasp�sienne en face du c�l�bre rocher Perc� et de l''�le Bonaventure.');
INSERT INTO Villes VALUES ('OKA', 'Oka', 3824, 'Oka est une municipalit� du Qu�bec situ�e dans la municipalit� r�gionale de comt� de Deux-Montagnes dans la r�gion des Laurentides.');
INSERT INTO Villes VALUES ('POC', 'Pointe-Calumet', 6428, 'Pointe-Calumet est une municipalit� d''environ 7 000 habitants, situ�e dans la municipalit� r�gionale de comt� de Deux-Montagnes au Qu�bec (Canada), r�gion administrative des Laurentides.');
INSERT INTO Villes VALUES ('LON', 'Longueuil', 246899, 'Longueuil est une ville du Qu�bec, au Canada, situ�e sur la rive sud du fleuve Saint-Laurent, face � Montr�al. Elle forme le coeur de l''agglom�ration de Longueuil, le secteur le plus urbanis� de la r�gion de la Mont�r�gie et de la banlieue sud de Montr�al.');
INSERT INTO Villes VALUES ('TAD', 'Tadoussac', 600, 'Tadoussac est un village canadien qui fait partie de la municipalit� r�gionale de comt� (MRC) de La Haute-C�te-Nord dans la r�gion administrative de la C�te-Nord au Qu�bec. Il est situ� au bord du fleuve Saint-Laurent. Tadoussac est le premier �tablissement fran�ais en Am�rique du Nord situ� au nord de la Floride fran�aise.');
INSERT INTO Villes VALUES ('SAG', 'Saguenay', 145949, 'Saguenay est une ville du Saguenay-Lac-Saint-Jean au Qu�bec. Situ�e dans une vall�e aux abords de la rivi�re Saguenay, elle est en amont du fjord du Saguenay et en aval du horst de K�nogami. Du nord au sud, elle s''�tend de la rive nord du Saguenay au massif des Laurentides. Sa superficie totale est de 1 136 km2.');
INSERT INTO Villes VALUES ('COA', 'Coaticook', 9183, 'Elle est surtout connue pour sa gorge et son pont suspendu pour pi�tons, cru le plus long au monde durant plusieurs ann�es avant de voir son record � fracass� �. Au m�me moment, le parc de la gorge s''est modernis�, r�novant presque enti�rement ses sentiers et annon�ant l''ouverture de nouveaux sentiers nocturnes.');
INSERT INTO Villes VALUES ('THM', 'Thetford Mines', 25649, 'Thetford Mines est une ville du Qu�bec, au Canada, situ�e dans la municipalit� r�gionale de comt� des Appalaches en Chaudi�re-Appalaches.');
INSERT INTO Villes VALUES ('BHN', 'Beauharnois', 12011, 'Beauharnois est une ville de la municipalit� r�gionale de comt� de Beauharnois-Salaberry situ�e au pays du Suro�t au Qu�bec. Beauharnois fait partie de la r�gion administrative de la Mont�r�gie et �galement partie de la Communaut� m�tropolitaine de Montr�al.');

-- Circuits
INSERT INTO Circuits VALUES(CircuitSeq.nextval, 'COA', 'PRC', 'Circuit De sud en est', 680, 4, 20);
INSERT INTO Circuits VALUES(CircuitSeq.nextval, 'MTL', 'SAG', 'Circuit D�couverte Fleuve et Saguenay', 570, 5, 13);
INSERT INTO Circuits VALUES(CircuitSeq.nextval, 'OKA', 'MTL', 'Circuit Montr�al et les alentours', 410, 2, 18);
INSERT INTO Circuits VALUES(CircuitSeq.nextval, 'PRC', 'OKA', 'Circuit D�couverte sud Qu�bec', 580, 4, 10);
INSERT INTO Circuits VALUES(CircuitSeq.nextval, 'PRC', 'MTL', 'Circuit D�couvert Qu�bec', 1000, 5, 5);
SELECT * FROM Circuits;
-- ListeMonuments
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Mus�e Beaulne'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Mus�e min�ralogique et minier de Thetford Mines'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Mus�e de la civilisation'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Centre d''interpr�tation des mammif�res marins'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Le Rocher Perc�'), 5);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Basilique Notre-Dame de Montr�al'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Jardin botanique de Montr�al'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='H�tel du Parlement du Qu�bec'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Chapelle des Indiens'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc national du Fjord-du-Saguenay'), 5);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montr�al et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc national d''Oka'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montr�al et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Super Aqua Club'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montr�al et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc Michel-Chartrand'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montr�al et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='La Centrale de Beauharnois'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montr�al et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='March� Jean-Talon'), 5);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couverte sud Qu�bec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Le Rocher Perc�'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couverte sud Qu�bec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Mus�e min�ralogique et minier de Thetford Mines'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couverte sud Qu�bec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc Michel-Chartrand'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couverte sud Qu�bec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Jardin botanique de Montr�al'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couverte sud Qu�bec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc national d''Oka'), 5);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couvert Qu�bec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Le Rocher Perc�'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couvert Qu�bec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Chapelle des Indiens'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couvert Qu�bec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Le ch�teau Frontenac'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couvert Qu�bec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Mus�e de la civilisation'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit D�couvert Qu�bec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='March� Jean-Talon'), 5);


COMMIT;