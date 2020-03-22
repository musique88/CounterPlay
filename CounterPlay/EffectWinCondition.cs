using System;

namespace CounterPlay
{
	public class EffectWinCondition : Effect
	{
		private Func<bool> CheckFunction;
		
		public EffectWinCondition(Timing timing, Func<bool> checkFunction)
		{
			base.Timing = timing;
			CheckFunction = checkFunction;
		}
		
		public override void Do()
		{
			CheckFunction();
		}
	}
}