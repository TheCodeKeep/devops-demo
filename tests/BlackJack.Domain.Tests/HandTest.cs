namespace BlackJack.Domain.Tests;

public class HandTest
{
    private Hand _hand;

    public HandTest()
    {
        _hand = new Hand();
    }

    [Fact]
    public void NewHand_HasNoCards()
    {
        Assert.Equal(0, _hand.NrOfCards);
    }

    [Fact]
    public void AddCard_EmptyHand_ResultsInHandWithOneCard()
    {
        BlackJackCard card = new BlackJackCard(FaceValue.Ace, Suit.Hearts);
        _hand.AddCard(card);

        Assert.Equal(1, _hand.NrOfCards);
    }

    [Fact]
    public void AddCard_AHandWithCards_AddsACard()
    {
        _hand.AddCard(new BlackJackCard(FaceValue.Two, Suit.Clubs));
        _hand.AddCard(new BlackJackCard(FaceValue.Two, Suit.Clubs));

        Assert.Equal(2, _hand.NrOfCards);
    }

    [Fact]
    public void TurnAllCardsFaceUp_TurnsAllCardsFaceUp()
    {
        BlackJackCard card = new BlackJackCard(FaceValue.Ace, Suit.Hearts);
        card.TurnCard();
        _hand.AddCard(card);
        _hand.AddCard(new BlackJackCard(FaceValue.Two, Suit.Clubs));
        _hand.AddCard(new BlackJackCard(FaceValue.Two, Suit.Clubs));
        _hand.TurnAllCardsFaceUp();
        foreach (BlackJackCard c in _hand.Cards)
            Assert.True(c.FaceUp);
    }

    [Fact]
    public void Value_EmptyHand_IsZero()
    {
        Assert.Equal(0, _hand.Value);
    }

    [Fact]
    public void Value_HandWith6and5_Is11()
    {
        _hand.AddCard(new BlackJackCard(FaceValue.Six, Suit.Clubs));
        _hand.AddCard(new BlackJackCard(FaceValue.Five, Suit.Clubs));
        _hand.TurnAllCardsFaceUp();

        Assert.Equal(11, _hand.Value);
    }

    [Fact]
    public void Value_HandWith5AndKing_Is15()
    {
        _hand.AddCard(new BlackJackCard(FaceValue.Five, Suit.Clubs));
        _hand.AddCard(new BlackJackCard(FaceValue.King, Suit.Clubs));
        _hand.TurnAllCardsFaceUp();

        Assert.Equal(15, _hand.Value);
    }

    [Fact]
    public void Value_HandWithCardsFacingDown_DoesNotAddValuesOfCardsFacingDown()
    {
        _hand.AddCard(new BlackJackCard(FaceValue.Two, Suit.Clubs));
        _hand.AddCard(new BlackJackCard(FaceValue.Two, Suit.Clubs));
        _hand.TurnAllCardsFaceUp();
        BlackJackCard card = new BlackJackCard(FaceValue.King, Suit.Hearts);
        _hand.AddCard(card);

        Assert.Equal(4, _hand.Value);
    }

    [Fact]
    public void Value_HandWithAceAndNotExceeding21_TakesAceAs11()
    {
        _hand.AddCard(new BlackJackCard(FaceValue.Seven, Suit.Clubs));
        _hand.AddCard(new BlackJackCard(FaceValue.Ace, Suit.Clubs));
        _hand.TurnAllCardsFaceUp();

        Assert.Equal(18, _hand.Value);
    }

    [Fact]
    public void ValueHandWithAceAndExceeding21_TakesAceAs1()
    {
        _hand.AddCard(new BlackJackCard(FaceValue.King, Suit.Clubs));
        _hand.AddCard(new BlackJackCard(FaceValue.Queen, Suit.Clubs));
        _hand.AddCard(new BlackJackCard(FaceValue.Ace, Suit.Clubs));
        _hand.TurnAllCardsFaceUp();

        Assert.Equal(21, _hand.Value);
    }

    [Fact]
    public void Value_HandWithAceFaceDown_DoesNotCountAce()
    {
        _hand.AddCard(new BlackJackCard(FaceValue.Two, Suit.Clubs));
        _hand.AddCard(new BlackJackCard(FaceValue.Two, Suit.Clubs));
        _hand.TurnAllCardsFaceUp();
        _hand.AddCard(new BlackJackCard(FaceValue.Ace, Suit.Clubs));
        Assert.Equal(4, _hand.Value);
    }
}
