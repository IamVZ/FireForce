# FireForce
Conception d'une application permettant la gestion complète de quatre casernes de pompiers
(personnel, matériel et missions effectuées).
Cette application offre les fonctionnalités suivantes :
- Volet 1 : tableau de bord des missions en cours.
- Volet 2 : création d’une nouvelle mission puis affectation du matériel nécessaire ainsi que
des pompiers missions.
- Volet 3 : Visualisation en mode 1 à 1 des engins d’une caserne donnée.
- Volet 4 : gestion du personnel d’une caserne (données signalétiques, carrière et habilitations
des pompiers ). L’aspect « mise à jour » est réservé aux utilisateurs disposant de droits
d’administration.
- Volet 5 : Statistiques à destination du régulateur.

# Image
## Tableau de bord

<img src="Document Annexe/Image/Tableau de bord.png" width="500" height="auto">

## Nouvelle mission

<img src="Document Annexe/Image/Nouvelle Mission.png" width="500" height="auto">

## Gestion engins

<img src="Document Annexe/Image/Gestion Engins.png" width="500" height="auto">

## Statistique

<img src="Document Annexe/Image/Statistiques.png" width="500" height="auto">

## Gestion personnel

<img src="Document Annexe/Image/Gestion du personnel.png" width="500" height="auto">

# Guide d'installation
outils necéssaire : Visual Studio Comunity

1) télécharger le zip du projet depuis le github
2) en raison des "Mark of the Web" appliqué par Windows
   * Clique droit sur Form1.resx
   * séléctionner "propriété"
   * dans l'onglet "général" cocher débloquer en bas à droite de la fenêtre
   * appuyer sur appliquer
   * ouvrir le projet "caserneWAVZ.sln"
4) déplacer la base de donné "SDIS67.db" dans le répertoire "caserneWAVZ/bin/debug"
   * si "caserne/bin" n'existe pas : compiler le projet --> cela le créera automatiquement
6) n'ayant pas d'executable, lancer le projet via Visual Studio Comunity

# Cahier des charges 
(<a href="./Document Annexe/Sujet SAE 24 Caserne - Session 2025.pdf">Consulter le cahier des charges</a>)


# Technolmogie utilisé : 
C#, .Net, WinForm, Sql
