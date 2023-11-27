namespace BlackJack.Domain.Tests.DeckStubs;

class DealerWinsPlayerBurnsDeck : Deck
{

    public DealerWinsPlayerBurnsDeck()
    {
        _cards = new List<BlackJackCard>
        {
            // Dealer
            new BlackJackCard(FaceValue.Seven, Suit.Clubs),
            new BlackJackCard(FaceValue.Seven, Suit.Clubs),
        
            // Player
            new BlackJackCard(FaceValue.Nine, Suit.Clubs),
            new BlackJackCard(FaceValue.Nine, Suit.Clubs),

            // Player
            new BlackJackCard(FaceValue.Ten, Suit.Clubs),

            // Dealer
            new BlackJackCard(FaceValue.Five, Suit.Clubs)
        };
    }
}
