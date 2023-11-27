namespace BlackJack.Domain;

public class Card
{
    public FaceValue FaceValue { get; private set; }
    public Suit Suit { get; private set; }

    public Card(FaceValue faceValue, Suit suit)
    {
        FaceValue = faceValue;
        Suit = suit;
    }
}
