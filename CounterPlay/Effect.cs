namespace CounterPlay
{
	public enum Timing
	{
		BEGIN, END, MOMENTARY
	};
	
	public abstract class Effect
	{
		public abstract void Do(Player Target);
		public Timing Timing;
		public bool IsEnabled;
	}
}