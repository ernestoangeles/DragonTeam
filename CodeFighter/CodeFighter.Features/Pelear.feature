﻿Feature: Pelear
//Escenario 3

Scenario: Jugador 1 Patea Jugador 2
	Given i enter the game
	When i enter player one "Pedro"
	And i enter player two "Jose"
	And i click "jugar"
	And i click "kick"
	Then player two life is "180"



//Escenario 1
	
Scenario: Jugador 1 y Jugador 2 tienen 200 de Vida al Iniciar el juego
	Given i enter the game
	When i enter player one "Pedro"
	And i enter player two "Jose"
	And i click "jugar"
	Then player one life is "200"
	Then player two life is "200"