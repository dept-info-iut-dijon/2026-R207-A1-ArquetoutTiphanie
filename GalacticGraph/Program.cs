using GalacticGraph;
using GalacticGraph.Metier.Cartes;

Carte carte = new Carte("");
Console.WriteLine("Carte créée avec succès !");

Coordonnees coord = new Coordonnees(5, 10);
Console.WriteLine($"Coordonnées : ligne={coord.Ligne}, colonne={coord.Colonne}");
IA ia = new IA();
ia.Start();