using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion
{
    internal class HunterLongLegs() : AbstractUnit(
        Name, "Hunter Long Legs",
        6, 4, 4,
        Pools.None,
        card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(OnKillEatTarget.Name),
            ];

            card.traits = [
                Rainfrost.TStack(Traits.Rot.Name),
            ];
        })
    {
        public const string Name = "HunterLongLegs";
    }
}