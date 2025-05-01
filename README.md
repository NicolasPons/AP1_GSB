# AP1 - Gestionnaire de Fiches de Frais

Bienvenue sur le dépôt GitHub de **AP1 - Gestionnaire de Fiches de Frais** !

Ce projet est une application de gestion des fiches de frais, développée dans le cadre de mon Atelier de Professionnalisation 1.

---

## Prérequis

Avant d'installer et d'utiliser l'application, vous devez :

1. Installer MariaDB.
2. Créer l'utilisateur : 'root' avec le mot de passe : root 
3. Configurer MariaDB pour écouter sur le **port 3307**.
4. Créer la base de données **gsb1**.
5. Importer le script SQL fourni dans le dossier BDD du repo git

---

## Installation

### 1. Installer MariaDB

- Téléchargez MariaDB : [https://mariadb.org/download/](https://mariadb.org/download/)
- Pendant l'installation, **changez le port par défaut** en **3307**.

> **Important** : MariaDB doit fonctionner sur le port **3307**, sinon l'application ne pourra pas se connecter à la base de données.

### 2. Configurer la base de données


- Connectez-vous à MariaDB (via un client comme HeidiSQL, DBeaver, ou en ligne de commande).
- Créez une base de données appelée `gsb1` :

```sql
CREATE DATABASE gsb1; 
```
- Importez le fichier .sql fourni dans le dossier BDD du dépôt pour créer les tables nécessaires.

### 3. Installer l'application

- Téléchargez l'archive contenant le fichier `setup.exe` depuis ce dépôt GitHub.
- Exécutez `setup.exe` pour installer l'application sur votre machine.
- Suivez les instructions de l'assistant d'installation.

### 4. Tester l'application

- Identifiant visiteur : visiteur / mdp : visiteur
- Identifiant comptable : compta / mdp : compta
- Identifiant admin : admin / mdp : admin
---

## Auteur

- Nicolas PONS
- BTS SIO - Atelier de professionnalisation 1
