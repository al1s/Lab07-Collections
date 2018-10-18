# Deck of cards

It's a simple console application with the goal to demonstrate ability to handle collections.

## Requirements 

- Create a custom generic collection named Deck<T>.
- This Generic collection should hold Cards.
- Create an Enum to hold the different card suits (Hearts, Diamonds, Spades, Clubs)
- The methods within your Deck class should contain at minimum:
- Add
- Remove
- ReturnSuit - this method will return all of the cards in that suit within the deck.
- Have a method named Deal that gets called from Main that evenly distributes the deck of cards amongst 2 players. the dealer keeps any remaining. Output to the console the cards each player has and what the dealer has kept. NOTE: The dealer is NOT a player.
- When running the application should activate a console that outputs each of the cards added to the deck, information about what card was removed, and then proof it is gone.

## Getting started

- Clone the repo;
- Build with `dotnet build --configuration Release`;
- Find the dll in `bin/Release` folder;
- Start with `dotnet DeckOfCards.dll`;

## Specs
### App
The program (should) contain the following:

- The instantiation of the generic collection.
- The instantiation of at least 10 cards with values
- Adding and removing cards from the Deck
- Proof that the ShowSuite method works
- Use a foreach loop on your created Deck, and output each of the cards to the console.

### Tests

- Add a card to your deck
- Getter/Setters of your properties from your Card class
- Remove a card from your deck that exists
- Remove a card from your deck that does not exist

## Screenshot

![image](https://raw.githubusercontent.com/al1s/Lab07-Collections/master/screenshot.PNG)