using System;

namespace CounterPlay
{
	public enum EffectSimpleTypes
	{
		Damage, Heal, Draw, Peek, ChooseScrap, IncCntr, DecCntr
	}
	
	public class EffectSimple : Effect
	{
		private EffectSimpleTypes Type;
		private int Power;
		public int DosRemaining;
		
		public EffectSimple(
			Timing timing = Timing.MOMENTARY, 
			EffectSimpleTypes type = EffectSimpleTypes.Damage, 
			int power = 1, 
			int dosRemaining = 0)
		{
			Power = power;
			Type = type;
			Timing = timing;
			IsEnabled = true;
			DosRemaining = dosRemaining;
		}
		
		public override void Do(Player Target)
		{
			switch (Type)
			{
				case EffectSimpleTypes.Draw:
					Card[] cards = Board.Instance.Deck.Draw(Power);
					for(int i = 0; i < cards.Length; ++i)
						Target.Hand.Add(cards[i]);
					break;
				
				case EffectSimpleTypes.Heal:
					Target.HP += Power;
					break;
				
				case EffectSimpleTypes.Peek:
					//TODO Implementation of PEEK Cards
					throw new NotImplementedException();
					break;
				
				case EffectSimpleTypes.Damage:
					Target.HP -= Power;
					break;
				
				case EffectSimpleTypes.ChooseScrap:
					//TODO Implementation of ChooseScrap Cards
					throw new NotImplementedException();
					break;
				
				case EffectSimpleTypes.DecCntr:
					Target.Counter -= Power;
					break;
				
				case EffectSimpleTypes.IncCntr:
					Target.Counter += Power;
					break;
			}

			if (--DosRemaining < 1)
				IsEnabled = false;
			if (Timing == Timing.MOMENTARY)
				IsEnabled = false;
		}
	}
}