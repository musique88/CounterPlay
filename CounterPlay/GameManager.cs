using System;

namespace CounterPlay
{
	public class GameManager
	{
		public int NumberOfPlayers = 2;

		public Board MainBoard;

		public GameManager(Card[] allTheCards)
		{
			Board.Initialize(2, allTheCards);
		}

		public override String ToString()
		{
			return "This is the GM speaking... we have " + NumberOfPlayers + " players.";
		}
	}
}