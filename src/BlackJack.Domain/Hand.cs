namespace BlackJack.Domain;

public sealed class Hand
{
    private IList<BlackJackCard> _cards = new List<BlackJackCard>();

    public IEnumerable<BlackJackCard> Cards => _cards;
    public int NrOfCards => _cards.Count;
    public int Value => CalculateValue();

    public void AddCard(BlackJackCard card)
    {
        _cards.Add(card);
    }

    public void TurnAllCardsFaceUp()
    {
        foreach (var card in _cards.Where(c => !c.FaceUp))
        {
            card.TurnCard();
        }
    }

    private int CalculateValue()
    {
        int sum = 0;

        foreach (var card in _cards)
        {
            if ((card.FaceValue == FaceValue.Ace && sum + 11 > 21) || card.FaceValue != FaceValue.Ace)
            {
                sum += card.Value;
            }
            else
            {
                sum += card.FaceUp ? 11 : card.Value;
            }
        }

        return sum;
    }
}
