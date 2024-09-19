using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class Saint() : AbstractUnit(
        Name, "Saint",
        health: 1, counter: 2,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(OnCardPlayedTransformIntoAttunedSaint.Name, 10),
            ];

            card.traits = [
                Rainfrost.TStack(Slugcat.Name),
                Rainfrost.TStack("Fragile")
            ];
        })
    {
        public const string Name = "Saint";
    }
}