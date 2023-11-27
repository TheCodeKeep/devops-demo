namespace BlackJack.Domain;

public class Deck
{
    private Random _random = new();
    protected IList<BlackJackCard> _cards = new List<BlackJackCard>();

    public Deck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (FaceValue value in Enum.GetValues(typeof(FaceValue)))
            {
                _cards.Add(
                    new BlackJackCard(
                        value,
                        suit
                    )
                );
            }
        }
    }

    public BlackJackCard Draw()
    {
        if (_cards.Count == 0)
        {
            throw new InvalidOperationException();
        }

        BlackJackCard card = _cards.First();

        _cards.RemoveAt(0);

        return card;
    }

    private void Shuffle()
    {
        for (int i = 0; i < _cards.Count * 3; i++)
        {
            int randomPosition = _random.Next(0, _cards.Count);
            var card = _cards[randomPosition];
            _cards.RemoveAt(randomPosition);
            _cards.Add(card);
        }
    }
}
