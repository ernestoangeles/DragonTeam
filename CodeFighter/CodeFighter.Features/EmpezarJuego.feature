﻿Feature: EmpezarJuego
//Escenario 9

Scenario: Ingresar Jugadores 
	Given i enter the game
	When i enter player one "Alan" 
	And i enter player two "Jose"
	And i click "Jugar"
	Then show "Alan" and "Jose"
	