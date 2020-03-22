namespace CounterPlay
{
	public enum EffectSimpleTypes
	{
		DAMAGE, HEAL, DRAW, PEEK, CHOOSESCRAP,
	}
	
	public class EffectSimple : Effect
	{
		private EffectSimpleTypes Type;
		private int Power;
		private Player Target;	
		
		public EffectSimple(Player target, Timing timing, EffectSimpleTypes type, int power)
		{
			Target = target;
			Power = power;
			Type = type;
			base.Timing = timing;
		}
		
		public override void Do()
		{
			
		}
	}
}