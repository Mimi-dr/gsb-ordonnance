GSB Ordonnance

Application de gestion des prescriptions médicales développée en C# .NET 8 avec une interface WinForms moderne.

📋 Description

GSB Ordonnance est une application de bureau complète permettant la gestion des patients, des prescriptions et de leurs interactions.
Elle offre une interface utilisateur intuitive avec un thème sombre, une authentification sécurisée et des fonctionnalités avancées d'export de données.


🛠 Technologie

C# .NET 8
WinForms
MySQL 8.0 (Docker)
BCrypt (authentification)
QuestPDF (export PDF)
Architecture MVC


✨ Fonctionnalités principales

Gestion complète des patients (CRUD)
Gestion des prescriptions avec transactions atomiques
Interface sombre et uniformisée
Authentification sécurisée avec BCrypt
Export de prescriptions en PDF
Démonstrations de sécurité (injection SQL)


📁 Structure du projet

models/           Modèles de données
controllers/      Logique métier
views/            Interfaces utilisateur
services/         Services applicatifs
Database.cs       Gestion de la connexion MySQL
Program.cs        Point d'entrée
