Feature: Pelear


@mytag
Scenario: Jugador 1 Patea Jugador 2
	Given i enter the game
	When i enter player one "Pedro"
	When i enter player two "Jose"
	When i click "jugar"
	When i click "kick"
	Then player two life is "180"

