namespace BlackJack.Domain;

public sealed class BlackJackCard : Card
{
    public bool FaceUp { get; set; }
    public int Value { get; private set; }

    public BlackJackCard(FaceValue faceValue, Suit suit) : base(faceValue, suit) 
    {
        FaceUp = false;
    }

    public void TurnCard()
    {
        FaceUp = !FaceUp;

        if (FaceUp) 
        {
            Value = CalculateValue();
        }
    }

    private int CalculateValue()
    {
        if (FaceValue is FaceValue.Jack or FaceValue.Queen or FaceValue.King)
        {
            return 10;
        }

        return (int)FaceValue;
    }
}
