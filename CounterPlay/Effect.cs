namespace CounterPlay
{
	public enum Timing
	{
		BEGIN, END, MOMENTARY
	};
	
	public abstract class Effect
	{
		public abstract void Do();
		public Timing Timing;
	}
}