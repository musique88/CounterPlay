using System;
using System.Collections.Generic;
using System.Linq;

namespace CounterPlay
{
	public static class ListUtils
	{
		private static Random rng = new Random();  

		public static void Shuffle<T>(this IList<T> list)  
		{  
			int n = list.Count;  
			while (n > 1) 
			{  
				n--;  
				int k = rng.Next(n + 1);  
				T value = list[k];  
				list[k] = list[n];  
				list[n] = value;  
			}  
		}
	}
	
	public class Deck
	{
		protected List<Card> Cards;

		public Deck(Card[] cards)
		{
			Cards = cards.ToList();
		}
		
		public Card[] Peek(int AmountOfCards)
		{
			List<Card> cards = new List<Card>();
			for (int i = 0; i < AmountOfCards; i++)
				cards.Add(Cards[i]);
			return cards.ToArray();	
		}
		
		public Card[] Draw(int AmountOfCards)
		{
			List<Card> cards = new List<Card>();
			for (int i = 0; i < AmountOfCards; i++)
			{
				cards.Add(Cards[i]);
				Cards.RemoveAt(i);
			}
			return cards.ToArray();	
		}

		public void Shuffle()
		{
			Cards.Shuffle();
		}

	}
}