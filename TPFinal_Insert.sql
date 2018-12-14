-- Séquence
/*DROP SEQUENCE ReservationSeq;
DROP SEQUENCE MonumentSeq;
DROP SEQUENCE CircuitSeq;
DROP SEQUENCE ClientSeq;*/

CREATE SEQUENCE ReservationSeq INCREMENT BY 1 START WITH 1;
CREATE SEQUENCE MonumentSeq INCREMENT BY 1 START WITH 1;
CREATE SEQUENCE CircuitSeq INCREMENT BY 1 START WITH 1;
CREATE SEQUENCE ClientSeq INCREMENT BY 1 START WITH 1;

-- Monuments
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Le château Frontenac', 1893, 'Le Château Frontenac est le premier d''une longue série d''hôtels de style « château » construits par les compagnies ferroviaires canadiennes à la fin du XIXe et au début du XXe siècle', 
                                'vide', 500, 4);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Le Rocher Percé', 1600, 'Le Rocher Percé est un îlot rocheux aux falaises escarpées possédant une arche naturelle et spectaculaire',
                                'vide', 200, 5);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Basilique Notre-Dame de Montréal', 1982, 'La basilique Notre-Dame de Montréal, sise dans l''arrondissement de Ville-Marie à Montréal, est l''église-mère de Montréal, la plus vaste de l''Archidiocèse de Montréal et la deuxième plus grande église de Montréal. Véritable galerie d''art religieux, elle abrite des ornements dont la richesse n''a pas d''équivalent à Montréal. ',
                                'vide', 75, 3);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Jardin botanique de Montréal', 1931, 'Le Jardin botanique de Montréal est situé dans l''est de la ville de Montréal au Québec (Canada) et il est l''un des plus importants jardins botaniques du monde1.',
                                'vide', 90, 3);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Marché Jean-Talon', 1929, 'Le marché Jean-Talon est un marché public au centre de la Petite Italie de Montréal.',
                                'vide', 50, 1);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Parc national d''Oka', 1990, 'Le parc national d''Oka est un parc national du Québec (Canada) situé près du village d''Oka, sur la rive nord du lac des Deux Montagnes.', 
                                'vide', 60, 2);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Super Aqua Club', 1985, 'En opération pendant les 10 semaines de l''été et avec plus de 45 attractions pour toute la famille, le Super Aqua Club est un parc aquatique complet qui accueille plusieurs milliers de visiteurs, chaque jour.', 
                                'vide', 100, 3);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Parc Michel-Chartrand', 1975, 'Le parc Michel-Chartrand, anciennement connu sous le nom de Parc régional de Longueuil, est un grand parc situé à Longueuil, au Québec, au Canada.', 
                                'vide', 75, 2);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Chapelle des Indiens', 1750, 'La chapelle des Indiens est l''une des plus anciennes églises en bois en Amérique du Nord.',
                                'vide', 50, 4);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Hôtel du Parlement du Québec', 1886, 'L''hôtel du Parlement du Québec1 est l''édifice abritant l''Assemblée nationale du Québec.',
                                'vide', 150, 5);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Parc national du Fjord-du-Saguenay', 1983, 'Le parc national du Fjord-du-Saguenay, d''une superficie de 326,7 km2, est un parc national du Québec situé à une centaine de kilomètres en aval de Saguenay sur la rivière du même nom.', 
                                'vide', 200, 4);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Centre d''interprétation des mammifères marins', 1991, 'Créé en 1991 par le Groupe de recherche et d''éducation sur les mammifères marins (GREMM), il est dédié à la recherche scientifique sur les baleines du Saint-Laurent. ', 
                                'vide', 75, 2);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Musée Beaulne', 1976, 'Le musée Beaulne, ouvert en 1976 est un musée situé à Coaticook, en Estrie, au Québec. Il est situé dans une grande maison de Style Queen Anne nommé château Arthur-Osmore-Norton.', 
                                'vide', 50, 1);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Musée minéralogique et minier de Thetford Mines', 1976, 'Le musée a été fondé par la Société minéralogique de la région de L''Amiante (SOMIRA), lors du centenaire de la découverte de l''amiante.', 
                                'vide', 150, 4);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'La Centrale de Beauharnois', 1961, 'La centrale de Beauharnois est une centrale hydroélectrique au fil de l''eau construite sur le Canal de Beauharnois, dans le secteur Melocheville de la Ville de Beauharnois', 
                                'vide', 120, 3);
INSERT INTO Monuments VALUES (MonumentSeq.nextval, 'Musée de la civilisation', 1988, 'Le musée présente des expositions thématiques temporaires et des permanentes ayant pour la plupart un lien avec les sciences humaines et sociales. Il est doté d''un important fonds d''objets d''intérêt ethnographique et historique. Il offre des visites guidées, des expositions interactives, un restaurant, un salon de détente et des spectacles.', 
                                'vide', 200, 5);
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
SELECT * FROM Circuits;
-- ListeMonuments
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Musée Beaulne'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Musée minéralogique et minier de Thetford Mines'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Musée de la civilisation'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Centre d''interprétation des mammifères marins'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit De sud en est'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Le Rocher Percé'), 5);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Basilique Notre-Dame de Montréal'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Jardin botanique de Montréal'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Hôtel du Parlement du Québec'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Chapelle des Indiens'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte Fleuve et Saguenay'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc national du Fjord-du-Saguenay'), 5);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montréal et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc national d''Oka'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montréal et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Super Aqua Club'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montréal et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc Michel-Chartrand'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montréal et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='La Centrale de Beauharnois'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Montréal et les alentours'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Marché Jean-Talon'), 5);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte sud Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Le Rocher Percé'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte sud Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Musée minéralogique et minier de Thetford Mines'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte sud Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc Michel-Chartrand'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte sud Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Jardin botanique de Montréal'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découverte sud Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Parc national d''Oka'), 5);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découvert Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Le Rocher Percé'), 1);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découvert Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Chapelle des Indiens'), 2);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découvert Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Le château Frontenac'), 3);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découvert Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Musée de la civilisation'), 4);
INSERT INTO ListeMonuments VALUES((SELECT NumCircuit FROM Circuits WHERE NomCircuit='Circuit Découvert Québec'), (SELECT NumMonument FROM Monuments WHERE NomMonument='Marché Jean-Talon'), 5);


COMMIT;