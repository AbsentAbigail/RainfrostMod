using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class Artificer() : AbstractUnit(
        Name, "Artificer",
        6, 4, 4,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(OnCardPlayedApplySpiceToCardsInHand.Name, 3),
            ];

            card.traits = [
                Rainfrost.TStack(Slugcat.Name)
            ];

            card.greetMessages = ["Wawa"];
        })
    {
        public const string Name = "Artificer";
    }
}