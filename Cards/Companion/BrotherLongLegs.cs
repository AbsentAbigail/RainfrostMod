using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class BrotherLongLegs() : AbstractUnit(
            Name, "Brother Long Legs",
            8, 2, 4,
            Pools.None,
            subscribe: data =>
            {
                data.startWithEffects = [
                    Rainfrost.SStack(TransformIntoDaddyLongLegsOnCardPlayed.Name, 1),
                    Rainfrost.SStack(OnCardPlayedDamageToNonRotAlliesInRow.Name, 2),
                ];
                data.traits = [
                    Rainfrost.TStack(Rot.Name),
                    Rainfrost.TStack("Barrage")
                ];
            }
        )
    {
        public const string Name = "BrotherLongLegs";
    }
}