using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class Gourmand() : AbstractUnit(
        Name, "Gourmand",
        8, 6, 5,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(OnCardPlayedSummonCopyOfLeftmostCardInHand.Name),
            ];

            card.traits = [
                Rainfrost.TStack(Slugcat.Name),
            ];
        })
    {
        public const string Name = "Gourmand";
    }
}