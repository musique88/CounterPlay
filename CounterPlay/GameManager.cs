using System;

namespace CounterPlay
{
	//TODO:
	// Make a GameState Class, that keeps track of the turn state,
	// Current Player, and Logs all the actions so that the Game
	// Can be replayed
	public enum GameState {
		BOARD_BOT, PLAYER_BOT, PLAYER_DRAW,
		PLAYER_TURN, PLAYER_EOT, PLAYER_DISCARD,
		PLAYER_COUNTER_RESET, BOARD_EOT, HANDOFF
	}

	public class GameManager
	{
		public int NumberOfPlayers = 2;

		public Board MainBoard;

		public GameManager(Card[] allTheCards)
		{
			MainBoard = Board.Initialize(2, allTheCards);
			
			Console.WriteLine(MainBoard);
		}

		public override String ToString()
		{
			return "This is the GM speaking... we have " + NumberOfPlayers + " players.";
		}
	}
}