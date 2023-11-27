namespace BlackJack.Domain.Tests.DeckStubs;

class PlayerWinsDealerBurnsDeck : Deck
{

    public PlayerWinsDealerBurnsDeck()
    {
        _cards = new List<BlackJackCard>
        {
            // Dealer
            new BlackJackCard(FaceValue.Seven, Suit.Clubs),
            new BlackJackCard(FaceValue.Seven, Suit.Clubs),
        
            // Player
            new BlackJackCard(FaceValue.Nine, Suit.Clubs),
            new BlackJackCard(FaceValue.Nine, Suit.Clubs),

            // Dealer
            new BlackJackCard(FaceValue.Ten, Suit.Clubs),
        };
    }
}
