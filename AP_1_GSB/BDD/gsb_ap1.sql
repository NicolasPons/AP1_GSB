-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : dim. 30 juin 2024 à 20:20
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gsb_ap1`
--

-- --------------------------------------------------------

--
-- Structure de la table `fiche_frais`
--

CREATE TABLE `fiche_frais` (
  `id_fiche_frais` int(11) NOT NULL,
  `date_fiche` date NOT NULL,
  `id_utilisateur` int(11) NOT NULL,
  `id_etat` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `fiche_frais`
--

INSERT INTO `fiche_frais` (`id_fiche_frais`, `date_fiche`, `id_utilisateur`, `id_etat`) VALUES
(23, '2024-05-11', 18, 1),
(24, '2024-06-11', 18, 2);

-- --------------------------------------------------------

--
-- Structure de la table `frais_forfait`
--

CREATE TABLE `frais_forfait` (
  `id_frais_forfait` int(11) NOT NULL,
  `quantite` int(11) NOT NULL,
  `date` date NOT NULL,
  `etat` enum('ATTENTE','ACCEPTER','REFUSER','') DEFAULT 'ATTENTE',
  `id_type_forfait` int(11) NOT NULL,
  `id_justificatif` int(11) DEFAULT NULL,
  `id_fiche_frais` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Structure de la table `frais_hors_forfait`
--

CREATE TABLE `frais_hors_forfait` (
  `id_hors_forfait` int(11) NOT NULL,
  `description` varchar(300) NOT NULL,
  `montant` float(10,3) NOT NULL,
  `date` date NOT NULL,
  `etat` enum('ATTENTE','ACCEPTER','REFUSER','') NOT NULL DEFAULT 'ATTENTE',
  `id_fiche_frais` int(10) NOT NULL,
  `id_justificatif` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Structure de la table `justificatif`
--

CREATE TABLE `justificatif` (
  `id_justificatif` int(11) NOT NULL,
  `fichier` mediumblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Structure de la table `role`
--

CREATE TABLE `role` (
  `id_role` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `role`
--

INSERT INTO `role` (`id_role`, `nom`) VALUES
(1, 'visiteur'),
(2, 'comptable'),
(3, 'administrateur');

-- --------------------------------------------------------

--
-- Structure de la table `type_etat`
--

CREATE TABLE `type_etat` (
  `id_etat` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `type_etat`
--

INSERT INTO `type_etat` (`id_etat`, `nom`) VALUES
(1, 'attente'),
(2, 'en_cours'),
(3, 'accepter'),
(4, 'refuser'),
(5, 'refus_partiel');

-- --------------------------------------------------------

--
-- Structure de la table `type_frais_forfait`
--

CREATE TABLE `type_frais_forfait` (
  `id_type_forfait` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `montant` float(10,3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `type_frais_forfait`
--

INSERT INTO `type_frais_forfait` (`id_type_forfait`, `nom`, `montant`) VALUES
(1, 'Nuitée', 60.000),
(2, 'Repas', 60.000),
(3, 'Frais kilométrique', 0.665),
(16, 'bvbvb', 25.333);

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `id_utilisateur` int(11) NOT NULL,
  `identifiant` varchar(50) NOT NULL,
  `mdp` varchar(20) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `id_role` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id_utilisateur`, `identifiant`, `mdp`, `nom`, `prenom`, `email`, `id_role`) VALUES
(18, 'visiteur', 'visiteur', 'visiteur', 'visiteur', 'visiteur@gsb.com', 1),
(19, 'compta', 'compta', 'compta', 'compta', 'compta@gsb.com', 2),
(20, 'admin', 'admin', 'admin', 'admin', 'admin@gsb.com', 3);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `fiche_frais`
--
ALTER TABLE `fiche_frais`
  ADD PRIMARY KEY (`id_fiche_frais`),
  ADD KEY `fk_id_utilisateur` (`id_utilisateur`),
  ADD KEY `fk_id_etat` (`id_etat`);

--
-- Index pour la table `frais_forfait`
--
ALTER TABLE `frais_forfait`
  ADD PRIMARY KEY (`id_frais_forfait`),
  ADD KEY `id_justificatif` (`id_justificatif`),
  ADD KEY `id_type_forfait` (`id_type_forfait`),
  ADD KEY `id_fiche_frais` (`id_fiche_frais`);

--
-- Index pour la table `frais_hors_forfait`
--
ALTER TABLE `frais_hors_forfait`
  ADD PRIMARY KEY (`id_hors_forfait`),
  ADD KEY `fk_id_fiche_frais` (`id_fiche_frais`),
  ADD KEY `fk_id_justificatif` (`id_justificatif`);

--
-- Index pour la table `justificatif`
--
ALTER TABLE `justificatif`
  ADD PRIMARY KEY (`id_justificatif`);

--
-- Index pour la table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id_role`);

--
-- Index pour la table `type_etat`
--
ALTER TABLE `type_etat`
  ADD PRIMARY KEY (`id_etat`);

--
-- Index pour la table `type_frais_forfait`
--
ALTER TABLE `type_frais_forfait`
  ADD PRIMARY KEY (`id_type_forfait`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id_utilisateur`),
  ADD KEY `fk_id_role` (`id_role`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `fiche_frais`
--
ALTER TABLE `fiche_frais`
  MODIFY `id_fiche_frais` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT pour la table `frais_forfait`
--
ALTER TABLE `frais_forfait`
  MODIFY `id_frais_forfait` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=120;

--
-- AUTO_INCREMENT pour la table `frais_hors_forfait`
--
ALTER TABLE `frais_hors_forfait`
  MODIFY `id_hors_forfait` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=71;

--
-- AUTO_INCREMENT pour la table `justificatif`
--
ALTER TABLE `justificatif`
  MODIFY `id_justificatif` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- AUTO_INCREMENT pour la table `role`
--
ALTER TABLE `role`
  MODIFY `id_role` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `type_etat`
--
ALTER TABLE `type_etat`
  MODIFY `id_etat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `type_frais_forfait`
--
ALTER TABLE `type_frais_forfait`
  MODIFY `id_type_forfait` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `id_utilisateur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `fiche_frais`
--
ALTER TABLE `fiche_frais`
  ADD CONSTRAINT `fk_id_etat` FOREIGN KEY (`id_etat`) REFERENCES `type_etat` (`id_etat`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_id_utilisateur` FOREIGN KEY (`id_utilisateur`) REFERENCES `utilisateur` (`id_utilisateur`) ON DELETE CASCADE;

--
-- Contraintes pour la table `frais_forfait`
--
ALTER TABLE `frais_forfait`
  ADD CONSTRAINT `frais_forfait_ibfk_1` FOREIGN KEY (`id_justificatif`) REFERENCES `justificatif` (`id_justificatif`) ON DELETE CASCADE,
  ADD CONSTRAINT `frais_forfait_ibfk_2` FOREIGN KEY (`id_type_forfait`) REFERENCES `type_frais_forfait` (`id_type_forfait`) ON DELETE CASCADE,
  ADD CONSTRAINT `frais_forfait_ibfk_3` FOREIGN KEY (`id_fiche_frais`) REFERENCES `fiche_frais` (`id_fiche_frais`) ON DELETE CASCADE;

--
-- Contraintes pour la table `frais_hors_forfait`
--
ALTER TABLE `frais_hors_forfait`
  ADD CONSTRAINT `fk_id_fiche_frais` FOREIGN KEY (`id_fiche_frais`) REFERENCES `fiche_frais` (`id_fiche_frais`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_id_justificatif` FOREIGN KEY (`id_justificatif`) REFERENCES `justificatif` (`id_justificatif`) ON DELETE CASCADE;

--
-- Contraintes pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD CONSTRAINT `fk_id_role` FOREIGN KEY (`id_role`) REFERENCES `role` (`id_role`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
