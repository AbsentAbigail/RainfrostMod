using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class LooksToTheMoon() : AbstractUnit(
            "LooksToTheMoon", "Looks To The Moon",
            attack: 0, counter: 3,
            subscribe: card =>
            {
                card.startWithEffects = [
                    Rainfrost.SStack("Scrap", 2),
                    Rainfrost.SStack(OnCardPlayedAddRandomPearlToHand.Name, 1)
                ];
                card.traits = [
                    Rainfrost.TStack(Iterator.Name)
                ];
                card.greetMessages = ["Hello, little creature!"];
            }
        )
    {
    }
}