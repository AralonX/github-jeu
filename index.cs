using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Premier_code : MonoBehaviour
{

	int vieDuJoueur = 100;

	void prendreDesDegats(int degatsEau, int degatsFeu, int degatsTerre, int degatsAir)
	{
		//Condition selon l'attaque ennemie
		vieDuJoueur -= ?;
	}

    private void Start()
    {
		Timer();
	}

	void Timer
	{
		// Code permettant de faire baisser le nombre de secondes restantes avant que la partie ne demarre
		// Si le timer atteint 0, la game se lance
		Startgame();
	}

	void Startgame()
	{
		// Demarrage de la partie
	}

	void Update()
	{
		// Si on appuie sur la fleche du haut, le personnage avance

		// Si on appuie sur la fleche du bas, le personnage recule

		// Si on appuie sur la fleche de droite, le personnage va a droite

		// Si on appuie sur la fleche de gauche, le personnage va a gauche

		// Si on appuie sur A, le personnage utilise l'eau
		capaciteEau();
		// Si on appuie sur Z, le personnage utilise le feu
		capaciteFeu();
		// Si on appuie sur E, le personnage utilise la terre
		capaciteTerre();
		// Si on appuie sur R, le personnage utilise le vent
		capaciteVent();
	}

	void capaciteEau()
	{
		// jouer l'animation
		// augmenter la jauge d'energie
	}

	void capaciteFeu()
	{
		// jouer l'animation
		// augmenter la jauge d'energie
	}

	void capaciteTerre()
	{
		// jouer l'animation
		// augmenter la jauge d'energie
	}

	void capaciteVent()
	{
		// jouer l'animation
		// augmenter la jauge d'energie
	}


}
