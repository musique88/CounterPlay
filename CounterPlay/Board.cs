using System;
using System.Collections.Generic;

namespace CounterPlay
{
	public sealed class Board
	{
		private static readonly Board instance = new Board();
		
		public Player[] Players;
		public Deck Deck;
		public ScrapPile ScrapPile;
		public Card.CardList CardsInPlay;
		
		private Board() { }
		public void Initialize(int AmountOfPlayers, Card[] StartingDeck)
		{
			if (instance != null)
				throw new Exception("AlreadyInitializedException");
			
			Players = new Player[AmountOfPlayers];
			Deck = new Deck(StartingDeck);
			ScrapPile = new ScrapPile();
			CardsInPlay.Cards = new List<Card>();
		}

		public static Board Instance => instance;
	}
}