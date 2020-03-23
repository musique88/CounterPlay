using System;
using System.Collections.Generic;

namespace CounterPlay
{
	public sealed class Board
	{
		private static Board instance;
		
		public Player[] Players;
		public Deck Deck;
		public ScrapPile ScrapPile;
		public Card.CardList CardsInPlay;

		private Board(int AmountOfPlayers, Card[] StartingDeck)
		{
			Players = new Player[AmountOfPlayers];
			Deck = new Deck(StartingDeck);
			ScrapPile = new ScrapPile();
			CardsInPlay = new Card.CardList();
		}
		public static Board Initialize(int AmountOfPlayers, Card[] StartingDeck)
		{
			if (instance != null)
			{
				throw new Exception("Already initialized.");
			}
			
			instance = new Board(AmountOfPlayers, StartingDeck);

			return instance;
		}

		public static Board Instance => instance;
	}
}