using System.Buffers.Text;

namespace CounterPlay
{
	public class ScrapPile : Deck
	{
		public Card[] GetCards() => Cards.ToArray();

		public ScrapPile() : base(new Card[0]) { }
	}
}