namespace BlackJack.Domain.Tests;

public class BlackJackCardTest
{
    [Fact]
    public void NewBlackJackCard_CreatedCorrectly()
    {
        BlackJackCard card = new BlackJackCard(FaceValue.Ace, Suit.Hearts);
        Assert.Equal(Suit.Hearts, card.Suit);
        Assert.Equal(FaceValue.Ace, card.FaceValue);
        Assert.False(card.FaceUp);
    }

    [Fact]
    public void TurnCard_CardFaceDown_TurnsCardToFaceUp()
    {
        BlackJackCard card = new BlackJackCard(FaceValue.Ace, Suit.Hearts);
        card.TurnCard();
        Assert.True(card.FaceUp);
    }

    [Fact]
    public void TurnCard_CardFaceUp_TurnsCardToFaceDown()
    {
        BlackJackCard card = new BlackJackCard(FaceValue.Ace, Suit.Hearts);
        card.TurnCard();
        card.TurnCard();
        Assert.False(card.FaceUp);
    }

    [Fact]
    public void Value_CardFaceUp_GivesCorrectValue()
    {
        BlackJackCard card = new BlackJackCard(FaceValue.King, Suit.Hearts);
        card.TurnCard();
        Assert.Equal(10, card.Value);
    }

    [Fact]
    public void Value_CardFaceDown_IsZero()
    {
        BlackJackCard card = new BlackJackCard(FaceValue.Ace, Suit.Hearts);
        Assert.Equal(0, card.Value);
    }
}
