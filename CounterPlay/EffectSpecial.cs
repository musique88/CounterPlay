using System;

namespace CounterPlay
{
	public class EffectSpecial : EffectSimple
	{
		private Func<bool> function;

		public EffectSpecial(
			Func<bool> function,
			int dosRemaining)
		{
			this.function = function;
			DosRemaining = dosRemaining;
		}
		
		public override void Do(Player Target)
		{
			function();
			DosRemaining--;
		}
	}
}