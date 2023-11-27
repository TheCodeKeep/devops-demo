namespace BlackJack.Domain.Tests;

public class CardTest
{
    [Fact]
    public void NewCardIsCreatedCorrectly()
    {
        Card card = new Card(FaceValue.Ace, Suit.Hearts);
        Assert.Equal(Suit.Hearts, card.Suit);
        Assert.Equal(FaceValue.Ace, card.FaceValue);
    }
}
