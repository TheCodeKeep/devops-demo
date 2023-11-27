namespace BlackJack.Domain.Tests.DeckStubs;

public class DealerWinNoBurnDeck : Deck
{

    public DealerWinNoBurnDeck()
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
            new BlackJackCard(FaceValue.Three, Suit.Clubs),
        };
    }
}
