using System.Collections.Generic;
using System.Linq;

namespace CounterPlay
{
	public enum CardType
	{
		BOARD, PLAYER, BOTH, MOMENTARY
	};
	
	public class Card
	{
		public int Cost;
		public CardType CardType;
		public List<Effect> Effects;

		public Card(int cost, CardType cardType, Effect[] effects)
		{
			Cost = cost;
			CardType = cardType;
			Effects = effects.ToList();
		}

		public class CardList
		{
			private List<Card> Cards;
			
			/// <summary>
			/// Returns all Beginning of turn (BOT) effects from cards
			/// </summary>
			/// <returns>Beginning of turn effects</returns>
			public Effect[] BOTEffects()
			{
				List<Effect> effects = new List<Effect>();
				for (int i = 0; i < Cards.Count; ++i)
					for (int j = 0; j < Cards[i].Effects.Count; ++i)
						if (Cards[i].Effects[j].Timing == Timing.BEGIN)
							effects.Append(Cards[i].Effects[j]);
				return effects.ToArray();
			}
			
			
			/// <summary>
			/// Returns all End of turn (EOT) effects from cards
			/// </summary>
			/// <returns>End of turn effects</returns>
			public Effect[] EOTEffects()
			{
				List<Effect> effects = new List<Effect>();
				for (int i = 0; i < Cards.Count; ++i)
				for (int j = 0; j < Cards[i].Effects.Count; ++i)
					if (Cards[i].Effects[j].Timing == Timing.END)
						effects.Append(Cards[i].Effects[j]);
				return effects.ToArray();
			}
		}
		
		
		
	}
}