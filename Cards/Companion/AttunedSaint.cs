using RainfrostMod.Helpers;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class AttunedSaint() : AbstractUnit(
        Name, "Attuned Saint",
        2, 0, 2,
        Pools.None,
        card =>
        {
            card.attackEffects = [
                Rainfrost.SStack("Kill", 1),
            ];

            card.startWithEffects = [
                Rainfrost.SStack("ImmuneToSnow"),
            ];

            card.traits = [
                Rainfrost.TStack(Slugcat.Name),
                Rainfrost.TStack("Fragile"),
            ];

            card.greetMessages = ["Wawa"];
        })
    {
        public const string Name = "AttunedSaint";
    }
}