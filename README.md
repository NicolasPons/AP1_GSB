AP1 - Gestionnaire de Fiches de Frais

Bienvenue sur le dépôt GitHub de AP1 - Gestionnaire de Fiches de Frais !

Ce projet est une application de gestion des fiches de frais, développée dans le cadre de mon Atelier de Professionnalisation 1.
Prérequis

Avant d'installer et d'utiliser l'application, vous devez :

    Installer MariaDB.

    Configurer MariaDB pour écouter sur le port 3307.

    Créer la base de données GSB1.

    Importer le script SQL fourni (dump.sql).

Installation
1. Installer MariaDB

    Téléchargez MariaDB : https://mariadb.org/download/

    Pendant l'installation, changez le port par défaut en 3307.

    Important : MariaDB doit fonctionner sur le port 3307, sinon l'application ne pourra pas se connecter à la base de données.

2. Configurer la base de données

    Connectez-vous à MariaDB (via un client comme HeidiSQL, DBeaver, ou le terminal).

    Créez une base de données appelée GSB1 :

CREATE DATABASE GSB1;

    Importez le fichier dump.sql fourni dans ce dépôt pour créer les tables nécessaires.

3. Installer l'application

    Téléchargez l'archive contenant le fichier setup.exe depuis ce dépôt GitHub.

    Exécutez setup.exe pour installer l'application sur votre machine.

    Suivez les instructions de l'assistant d'installation.

Utilisation

    Vérifiez que MariaDB est bien démarré sur le port 3307.

    Lancez l'application installée depuis le menu Démarrer ou votre raccourci bureau.

    Connectez-vous et commencez à gérer vos fiches de frais !

Problèmes courants

    Connexion échouée à la base de données : Vérifiez que MariaDB est actif, que la base GSB1 existe, et que vous utilisez bien le port 3307.

    Erreur lors de l'import du dump.sql : Assurez-vous que vous êtes connecté à la base GSB1 avant d'exécuter le script.

Auteur

    [Ton Prénom Nom]

    BTS SIO - Atelier de professionnalisation 1
