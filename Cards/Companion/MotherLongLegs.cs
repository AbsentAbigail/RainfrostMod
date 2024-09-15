using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class MotherLongLegs() : AbstractUnit(
            Name, "Mother Long Legs",
            12, 6, 4,
            Pools.None,
            subscribe: data =>
            {
                data.startWithEffects = [
                    Rainfrost.SStack(OnCardPlayedDamageToNonRotAlliesInRow.Name, 6),
                    Rainfrost.SStack("When X Health Lost Split", 3),
                ];
                data.traits = [
                    Rainfrost.TStack(Rot.Name),
                    Rainfrost.TStack("Barrage")
                ];
            }
        )
    {
        public const string Name = "MotherLongLegs";
    }
}