Feature: Ganar

Scenario: Gana Jugador 1
	Given i enter the game
	When i enter player one "Pedro"
	And i enter player two "Jose"
	And i click "jugar"
	And i click "kick-player-1"
	And i click "kick-player-1"
	And i click "kick-player-1"
	And i click "kick-player-1"
	And i click "kick-player-1"
	And i click "kick-player-1"
	And i click "kick-player-1"
	And i click "kick-player-1"
	And i click "kick-player-1"
	And i click "kick-player-1"
	Then i should see "Pedro ganó."

