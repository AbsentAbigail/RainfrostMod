using RainfrostMod.Helpers;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class AttunedSaint() : AbstractUnit(
        Name, "Attuned Saint",
        1, 0, 2,
        Pools.None,
        card =>
        {
            card.attackEffects = [
                Rainfrost.SStack("Reduce Max Health", 50)
            ];

            card.traits = [
                Rainfrost.TStack(Slugcat.Name),
                Rainfrost.TStack("Fragile")
            ];
        })
    {
        public const string Name = "AttunedSaint";
    }
}