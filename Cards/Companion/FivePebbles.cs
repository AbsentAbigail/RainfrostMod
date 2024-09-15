using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class FivePebbles() : AbstractUnit(
        "FivePebbles", "Five Pebbles",
            attack: 0, counter: 5,
            subscribe: data =>
            {
                data.startWithEffects = [
                    Rainfrost.SStack("Scrap", 3),
                    Rainfrost.SStack(SummonBrotherLongLegs.Name),
                    Rainfrost.SStack("On Card Played Lose Scrap To Self", 1)
                ];
                data.traits = [
                    Rainfrost.TStack(Iterator.Name),
                    Rainfrost.TStack("Spark")
                ];
            }
        )
    {
    }
}