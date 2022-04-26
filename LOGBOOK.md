# Journal de bord
L'objectif de ce journal de bord est de suivre l'avancée de mes recherches ainsi que ma prise de notes.

# Analyse des ressources

## Tesla lightshow 
Tesla propose sur son github, un dossier exemple de son lightshow ainsi que toutes les explications d'utilisation et de conception.

[Documentation](https://github.com/teslamotors/light-show) de Tesla sur le Github officiel sur l'utilisation et la mise en place de lightshow.

## Beat Saber
Beatsaber propose une documentation de sa structure de donnée initalement prévue pour les développeurs de niveaux pour le jeu. Cette documentation permet de mieux comprendre les fichiers de jeu (aussi appelés : map)

[Documentation](https://bsmg.wiki/mapping/map-format.html#base-object) beatsaber pour les maps.

## TeslaLightShare.io
Teslashare.io est une plateforme qui permet aux personnes de facilement pouvoir partager leur création de lightshow. Cependant, ce site ne permet pas la création de lightshow, il s'agit uniquement d'un répertoire.

#Roadmap
## Objectifs en cours

- Analyser et comprendre le fonctionnement des maps de beatsaber
- Analyser et comprendre le fonctionnement d'un lightshow Tesla
- Analyser la structure à mettre en place pour l'API
- Comprendre le fonctionnement du [site de téléchargement de map beatsaber](https://bsaber.com)

#Beatsaber

Beatsaber utilise une structure de dossier toujours identique pour les "maps".
La structure ce présente de la manière suivante :

![](images/logbook/structure_dossier_bsaber.PNG)

- **Info.dat** : le fichier contient toutes les informations nécéssaires concernant la musique / le niveau.
- **nom_musique.egg** : il s'agit du fichier audio de la map. BeatSaber demande un fichier audio de type EGG.
- **cover.jpg** : Comme son nom l'indique, il s'agit de l'image de la map.
- **NormalStandart.dat / NormalHard.dat / etc.** : Ce sont les fichiers contenant les datas des niveaux. Ces fichiers indiquent le timecode, la durée et autres informations concernant les obstacles et les cubes à détruire.

### Analyse fichier .dat (map)
On retrouve plusieurs tableau avec des informations :

- **notes** : toutes les notes des niveaux a casser / couper
- **obstacles** : Les blocs d'obstacles à éviter 
- **events** : Des évenements annexes
- **waypoints** : Les checkpoints de sauvegarde
- **customData** : Des données annexes que le créateur peut ajouter à la map

Le tableau des notes est composé de pleins de notes avec les informations suivantes :

- **time** : l'instant i de l'apparition du bloc
- **lineindex** : Un nombre entier, de 0 à 3, qui représente la colonne où se trouve cette note. La colonne la plus à gauche est située à l'indice 0, et augmente jusqu'à la colonne la plus à droite située à l'indice 3.
- **linelayer** : Un nombre entier, de 0 à 2, qui représente la couche où se trouve cette note. La couche la plus basse est située à la couche 0, et augmente jusqu'à la couche la plus haute située à l'indice 2.
- **type** : le type de bloc
- **cutDirection** : La direction dans laquelle il faut couper le bloc

Voici les types possibles :

|type   | description  |
|---|---|
|  0 | Left (Red) Note  |
|  1|  Right (Blue) Note |
|  2 | Unused  |
|  3 | Bomb  |