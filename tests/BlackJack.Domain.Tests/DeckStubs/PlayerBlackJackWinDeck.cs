namespace BlackJack.Domain.Tests.DeckStubs;

class PlayerBlackJackWinDeck : Deck
{

    public PlayerBlackJackWinDeck()
    {
        _cards = new List<BlackJackCard>
        {
            // Dealer
            new BlackJackCard(FaceValue.Seven, Suit.Clubs),
            new BlackJackCard(FaceValue.Seven, Suit.Clubs),
        
            // Player
            new BlackJackCard(FaceValue.Ace, Suit.Clubs),
            new BlackJackCard(FaceValue.Ten, Suit.Clubs),

            // Dealer
            new BlackJackCard(FaceValue.Ten, Suit.Clubs),
        };
    }
}
