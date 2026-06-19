Présentation:
GalacticGraph est une IA capable d'explorer automatiquement une carte hexagonale en évitant ou traversant les astéroîdes en utilisant l'algorithme de Disjkstra pour calculer les plus court chemins pondérés.

Architecture:

Algorithme de Disjkstra:
L'algorithme calcule les plus courts chemins depuis la position du vaisseau en tenant compte des coûts de déplacement:
- Case normale: coût = 1
- Case Astéroïde: coût = 2
L'algorithme s'arrête dès qu'il atteint une case inconnue (optimisation) pour éviter de parcourir tout le graphe à chaque tour.

Fonctionnement de l'IA:
- Demande à la carte du serveur
- Creer un vaisseau
- Si une case voisine est inconnue, redemande la carte
- Sinon, calcule le chemin veres la case inconnue la plus proche avec Dijkstra
- Execute les ordres un par un
- Répète jusqu'à ce que toute la carte soit explorée

Heuristique:
Pour fluidifier l'exploration de la carte, elle favorise les cases éloignées de la base.

Lancer le projet:
1. Ouvrir GalacticGraph.sln dans Visual Studio
2. Vérifier que le serveur de jeu est lancé
3. Lancer le projet

Tests unitaires:
- TestDijkstra: vérifie les distances calculées par Dijkstra
- TestDijkstraChemin: vérifie les chemins retournés par GetChemin
