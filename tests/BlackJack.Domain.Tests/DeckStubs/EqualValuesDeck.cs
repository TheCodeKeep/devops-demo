namespace BlackJack.Domain.Tests.DeckStubs;

public class EqualValuesDeck : Deck
{

    public EqualValuesDeck()
    {
        _cards = new List<BlackJackCard>
        {
            // Dealer
            new BlackJackCard(FaceValue.Seven, Suit.Clubs),
            new BlackJackCard(FaceValue.Five, Suit.Clubs),
        
            // Player
            new BlackJackCard(FaceValue.Seven, Suit.Clubs),
            new BlackJackCard(FaceValue.Seven, Suit.Clubs),

            // Dealer
            new BlackJackCard(FaceValue.Two, Suit.Clubs)
        };
    }
}
