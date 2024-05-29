-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 29 mai 2024 à 15:24
-- Version du serveur : 10.4.28-MariaDB
-- Version de PHP : 8.2.4

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

-- --------------------------------------------------------

--
-- Structure de la table `frais_forfait`
--

CREATE TABLE `frais_forfait` (
  `id_frais_forfait` int(11) NOT NULL,
  `quantite` int(11) NOT NULL,
  `date` date NOT NULL,
  `etat` enum('ATTENTE','ACCEPTE','REFUSE','') DEFAULT NULL,
  `id_type_forfait` int(11) NOT NULL,
  `id_justificatif` int(11) DEFAULT NULL,
  `id_fiche_frais` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Structure de la table `frais_hors_forfait`
--

CREATE TABLE `frais_hors_forfait` (
  `id_forfait` int(11) NOT NULL,
  `description` varchar(300) NOT NULL,
  `montant` int(50) NOT NULL,
  `etat` enum('ATTENTE','ACCEPTE','REFUSE','') NOT NULL,
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

-- --------------------------------------------------------

--
-- Structure de la table `type_etat`
--

CREATE TABLE `type_etat` (
  `id_etat` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Structure de la table `type_frais_forfait`
--

CREATE TABLE `type_frais_forfait` (
  `id_type_forfait` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `montant` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

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
  ADD PRIMARY KEY (`id_forfait`),
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
  MODIFY `id_fiche_frais` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `frais_forfait`
--
ALTER TABLE `frais_forfait`
  MODIFY `id_frais_forfait` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `frais_hors_forfait`
--
ALTER TABLE `frais_hors_forfait`
  MODIFY `id_forfait` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `justificatif`
--
ALTER TABLE `justificatif`
  MODIFY `id_justificatif` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `role`
--
ALTER TABLE `role`
  MODIFY `id_role` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `type_etat`
--
ALTER TABLE `type_etat`
  MODIFY `id_etat` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `type_frais_forfait`
--
ALTER TABLE `type_frais_forfait`
  MODIFY `id_type_forfait` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `id_utilisateur` int(11) NOT NULL AUTO_INCREMENT;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `fiche_frais`
--
ALTER TABLE `fiche_frais`
  ADD CONSTRAINT `fk_id_etat` FOREIGN KEY (`id_etat`) REFERENCES `type_etat` (`id_etat`),
  ADD CONSTRAINT `fk_id_utilisateur` FOREIGN KEY (`id_utilisateur`) REFERENCES `utilisateur` (`id_utilisateur`);

--
-- Contraintes pour la table `frais_forfait`
--
ALTER TABLE `frais_forfait`
  ADD CONSTRAINT `frais_forfait_ibfk_1` FOREIGN KEY (`id_justificatif`) REFERENCES `justificatif` (`id_justificatif`),
  ADD CONSTRAINT `frais_forfait_ibfk_2` FOREIGN KEY (`id_type_forfait`) REFERENCES `type_frais_forfait` (`id_type_forfait`),
  ADD CONSTRAINT `frais_forfait_ibfk_3` FOREIGN KEY (`id_fiche_frais`) REFERENCES `fiche_frais` (`id_fiche_frais`);

--
-- Contraintes pour la table `frais_hors_forfait`
--
ALTER TABLE `frais_hors_forfait`
  ADD CONSTRAINT `fk_id_fiche_frais` FOREIGN KEY (`id_fiche_frais`) REFERENCES `fiche_frais` (`id_fiche_frais`),
  ADD CONSTRAINT `fk_id_justificatif` FOREIGN KEY (`id_justificatif`) REFERENCES `justificatif` (`id_justificatif`);

--
-- Contraintes pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD CONSTRAINT `fk_id_role` FOREIGN KEY (`id_role`) REFERENCES `role` (`id_role`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
