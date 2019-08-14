-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mer 14 Mars 2019 à 23:34
-- Version du serveur :  10.1.19-MariaDB
-- Version de PHP :  5.5.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `gsb_frais`
--

-- --------------------------------------------------------
--
-- Structure de la table `typeUtilisateur`
--

CREATE TABLE `typeUtilisateur` (
  `codeType` varchar(3) NOT NULL,
  `intitulé` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Index pour la table `typeUtilisateur`
--
ALTER TABLE `typeUtilisateur`
  ADD PRIMARY KEY (`codeType`);
  
--  
-- Contenu de la table typeUtilisateur;
--
INSERT INTO `typeUtilisateur` (`codeType`, `intitulé`) VALUES
('CMP','Comptable'),
('GST','Gestionnaire'),
('VIS','Ordre');
-- --------------------------------------------------------
--
-- Structure de la table `etat`
--

CREATE TABLE `etat` (
  `codeEtat` varchar(2) NOT NULL,
  `nom` varchar(75) NOT NULL,
  `ordre` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Index pour la table `etat`
--
ALTER TABLE `etat`
  ADD PRIMARY KEY (`codeEtat`);
  
--
-- Contenu de la table etat;
--
INSERT INTO `etat` (`codeEtat`, `nom`,`ordre`) VALUES
('EC','En cours de saisie (par le visiteur)',1),
('CL','Clôturée (par le gestionnaire, ou par le visiteur, au plus tard le 10 du mois suivant)',2),
('VA','Validée (par le service comptable)',3),
('MP','Mise en paiement (par le gestionnaire)',4),
('RE','Remboursée (par le gestionnaire)',5);

-- --------------------------------------------------------
--
-- Structure de la table `typefrais`
--

CREATE TABLE `typefrais` (
  `id` char(3) NOT NULL,
  `libelle` char(20) NOT NULL,
  `montant` decimal(5,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Index pour la table `typefrais`
--
ALTER TABLE `typefrais`
  ADD PRIMARY KEY (`id`);
  
--
-- Contenu de la table `typefrais`
--

INSERT INTO `typefrais` (`id`, `libelle`, `montant`) VALUES
('ETP', 'Forfait Etape', '110.00'),
('KM', 'Frais Km', '0.70'),
('NUI', 'Nuitée Hôtel', '80.00'),
('REP', 'Repas Restaurant', '25.00');

-- --------------------------------------------------------
--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `id` char(4) NOT NULL,
  `nom` char(30) DEFAULT NULL,
  `prenom` char(30) DEFAULT NULL,
  `login` char(20) DEFAULT NULL,
  `mdp` char(20) DEFAULT NULL,
  `adresse` char(30) DEFAULT NULL,
  `cp` char(5) DEFAULT NULL,
  `ville` char(30) DEFAULT NULL,
  `dateEmbauche` date DEFAULT NULL,
  `codeType` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id`);

--
-- Contraintes pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD CONSTRAINT `utilisateur_ibfk_1` FOREIGN KEY (`codeType`) REFERENCES `typeUtilisateur` (`codeType`);

--
-- Contenu de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `nom`, `prenom`, `login`, `mdp`, `adresse`, `cp`, `ville`, `dateEmbauche`,`codeType`) VALUES
('a1', 'Grossous', 'Monique', 'compta', '12345', '35 avenue de la monnaie', '33000', 'Bordeaux', '2014-06-11','CMP'),
('a131', 'Villechalane', 'Louis', 'lvillachane', 'jux7g', '8 rue des Charmes', '46000', 'Cahors', '2005-12-21','VIS'),
('a17', 'Andre', 'David', 'dandre', 'oppg5', '1 rue Petit', '46200', 'Lalbenque', '1998-11-23','VIS'),
('a55', 'Bedos', 'Christian', 'cbedos', 'gmhxd', '1 rue Peranud', '46250', 'Montcuq', '1995-01-12','VIS'),
('a93', 'Tusseau', 'Louis', 'ltusseau', 'ktp3s', '22 rue des Ternes', '46123', 'Gramat', '2000-05-01','VIS'),
('b13', 'Bentot', 'Pascal', 'pbentot', 'doyw1', '11 allée des Cerises', '46512', 'Bessines', '1992-07-09','VIS'),
('b16', 'Bioret', 'Luc', 'lbioret', 'hrjfs', '1 Avenue gambetta', '46000', 'Cahors', '1998-05-11','VIS'),
('b19', 'Bunisset', 'Francis', 'fbunisset', '4vbnd', '10 rue des Perles', '93100', 'Montreuil', '1987-10-21','VIS'),
('b25', 'Bunisset', 'Denise', 'dbunisset', 's1y1r', '23 rue Manin', '75019', 'paris', '2010-12-05','VIS'),
('b28', 'Cacheux', 'Bernard', 'bcacheux', 'uf7r3', '114 rue Blanche', '75017', 'Paris', '2009-11-12','VIS'),
('b34', 'Cadic', 'Eric', 'ecadic', '6u8dc', '123 avenue de la République', '75011', 'Paris', '2008-09-23','VIS'),
('b4', 'Charoze', 'Catherine', 'ccharoze', 'u817o', '100 rue Petit', '75019', 'Paris', '2005-11-12','VIS'),
('b50', 'Clepkens', 'Christophe', 'cclepkens', 'bw1us', '12 allée des Anges', '93230', 'Romainville', '2003-08-11','VIS'),
('b59', 'Cottin', 'Vincenne', 'vcottin', '2hoh9', '36 rue Des Roches', '93100', 'Monteuil', '2001-11-18','VIS'),
('c14', 'Daburon', 'François', 'fdaburon', '7oqpv', '13 rue de Chanzy', '94000', 'Créteil', '2002-02-11','VIS'),
('c3', 'De', 'Philippe', 'pde', 'gk9kx', '13 rue Barthes', '94000', 'Créteil', '2010-12-14','VIS'),
('c54', 'Debelle', 'Michel', 'mdebelle', 'od5rt', '181 avenue Barbusse', '93210', 'Rosny', '2006-11-23','VIS'),
('d13', 'Debelle', 'Jeanne', 'jdebelle', 'nvwqq', '134 allée des Joncs', '44000', 'Nantes', '2000-05-11','VIS'),
('d51', 'Debroise', 'Michel', 'mdebroise', 'sghkb', '2 Bld Jourdain', '44000', 'Nantes', '2001-04-17','VIS'),
('e22', 'Desmarquest', 'Nathalie', 'ndesmarquest', 'f1fob', '14 Place d Arc', '45000', 'Orléans', '2005-11-12','VIS'),
('e24', 'Desnost', 'Pierre', 'pdesnost', '4k2o5', '16 avenue des Cèdres', '23200', 'Guéret', '2001-02-05','VIS'),
('e39', 'Dudouit', 'Frédéric', 'fdudouit', '44im8', '18 rue de l église', '23120', 'GrandBourg', '2000-08-01','VIS'),
('e49', 'Duncombe', 'Claude', 'cduncombe', 'qf77j', '19 rue de la tour', '23100', 'La souteraine', '1987-10-10','VIS'),
('e5', 'Enault-Pascreau', 'Céline', 'cenault', 'y2qdu', '25 place de la gare', '23200', 'Gueret', '1995-09-01','VIS'),
('e52', 'Eynde', 'Valérie', 'veynde', 'i7sn3', '3 Grand Place', '13015', 'Marseille', '1999-11-01','VIS'),
('f21', 'Finck', 'Jacques', 'jfinck', 'mpb3t', '10 avenue du Prado', '13002', 'Marseille', '2001-11-10','VIS'),
('f39', 'Frémont', 'Fernande', 'ffremont', 'xs5tq', '4 route de la mer', '13012', 'Allauh', '1998-10-01','VIS'),
('f4', 'Gest', 'Alain', 'agest', 'dywvt', '30 avenue de la mer', '13025', 'Berre', '1985-11-01','GST');
-- --------------------------------------------------------
--
-- Structure de la table `fichefrais`
--

CREATE TABLE `fichefrais` (
  `idFiche` int(11) NOT NULL,
  `idUtilisateur` char(4) NOT NULL,
  `mois` int(2) NOT NULL,
  `annee` int(4) NOT NULL,
  `dateCreation` date NOT NULL,
  `dateCloture` date DEFAULT NULL,
  `etat` varchar(2) NOT NULL DEFAULT 'EC',
  `montantDeclare` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Index pour la table `fichefrais`
--
ALTER TABLE `fichefrais`
  ADD PRIMARY KEY (`idFiche`),
  ADD KEY `idUtilisateur` (`idUtilisateur`);
--
-- AUTO_INCREMENT pour la table `fichefrais`
--
ALTER TABLE `fichefrais`
  MODIFY `idFiche` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Contraintes pour la table `fichefrais`
--
ALTER TABLE `fichefrais`
  ADD CONSTRAINT `fichefrais_ibfk_1` FOREIGN KEY (`idUtilisateur`) REFERENCES `utilisateur` (`id`),
  ADD CONSTRAINT `fichefrais_ibfk_2` FOREIGN KEY (`etat`) REFERENCES `etat` (`codeEtat`);

--
-- Contenu de la table `fichefrais`
--

INSERT INTO `fichefrais` (`idFiche`, `idUtilisateur`, `mois`, `annee`, `dateCreation`, `dateCloture`, `etat`, `montantDeclare`) VALUES
(1, 'a17', 1, 2019, '2019-02-01', '2019-02-01', 'CL', '194.00'),
(2, 'a55', 1, 2019, '2019-02-02', '2019-02-02', 'VA', '262.60'),
(3, 'b13', 1, 2019, '2019-02-02', '2019-02-09', 'MP', '141.00'),
(4, 'e5', 1, 2019, '2019-02-03', '2019-02-09', 'MP', '1625.00'),
(5, 'c3', 1, 2019, '2019-02-04', '2019-02-05', 'CL', '1076.00'),
(6, 'a55', 2, 2019, '2019-03-05', '2019-03-05', 'RE', '559.30'),
(7, 'b59', 2, 2019, '2019-03-05', '2019-03-09', 'VA', '1135.00'),
(8, 'b13', 2, 2019, '2019-03-06', '2019-03-06', 'RE', '977.00'),
(9, 'a131', 2, 2019, '2019-03-07', NULL, 'EC', NULL),
(10, 'b16', 2, 2019, '2019-03-07', '2019-03-07', 'RE', '211.50'),
(11, 'b34', 3, 2019, '2019-03-17', NULL, 'EC', '80.00'),
(12, 'b4', 3, 2019, '2019-01-19', NULL, 'EC', NULL);

-- --------------------------------------------------------
--
-- Structure de la table `lignefrais`
--

CREATE TABLE `lignefrais` (
  `idFiche` int(11) NOT NULL,
  `idTypeFrais` char(3) NOT NULL,
  `quantiteDeclaree` int(11) DEFAULT NULL,
  `quantiteValide` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Index pour la table `lignefrais`
--
ALTER TABLE `lignefrais`
  ADD PRIMARY KEY (`idFiche`,`idTypeFrais`),
  ADD KEY `idTypeFrais` (`idTypeFrais`);
--
-- Contraintes pour la table `lignefrais`
--
ALTER TABLE `lignefrais`
  ADD CONSTRAINT `lignefrais_ibfk_1` FOREIGN KEY (`idTypeFrais`) REFERENCES `typefrais` (`id`),
  ADD CONSTRAINT `lignefrais_ibfk_2` FOREIGN KEY (`idFiche`) REFERENCES `fichefrais` (`idFiche`);


--
-- Contenu de la table `lignefrais`
--

INSERT INTO `lignefrais` (`idFiche`, `idTypeFrais`, `quantiteDeclaree`,`quantiteValide`) VALUES
(1, 'ETP', 1,NULL),
(1, 'KM', 120,NULL),
(2, 'ETP', 1,NULL),
(2, 'KM', 218,NULL),
(3, 'KM', 130,NULL),
(3, 'REP', 2,NULL),
(4, 'ETP', 3,NULL),
(4, 'KM', 300,NULL),
(4, 'NUI', 12,NULL),
(4, 'REP', 5,NULL),
(5, 'ETP', 3,NULL),
(5, 'KM', 280,NULL),
(5, 'REP', 22,NULL),
(6, 'ETP', 3,NULL),
(6, 'KM', 99,NULL),
(6, 'NUI', 2,NULL),
(7, 'ETP', 2,NULL),
(7, 'KM', 850,NULL),
(7, 'NUI', 4,NULL),
(8, 'KM', 560,NULL),
(8, 'NUI', 7,NULL),
(8, 'REP', 1,NULL),
(10, 'ETP', 1,NULL),
(10, 'KM', 145,NULL),
(11, 'NUI', 1,NULL);

-- --------------------------------------------------------
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
