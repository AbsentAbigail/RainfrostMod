using RainfrostMod.Helpers;

namespace RainfrostMod.Cards.Companion
{
    internal class HunterLongLegs() : AbstractUnit(
        Name, "Hunter Long Legs",
        6, 4, 4,
        Pools.None,
        card =>
        {
            card.traits = [
                Rainfrost.TStack(Traits.Rot.Name),
                Rainfrost.TStack("Barrage"),
            ];
        })
    {
        public const string Name = "HunterLongLegs";
    }
}