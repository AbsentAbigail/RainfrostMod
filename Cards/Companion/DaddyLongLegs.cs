using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class DaddyLongLegs() : AbstractUnit(
            Name, "Daddy Long Legs",
            10, 4, 4,
            Pools.None,
            subscribe: data =>
            {
                data.startWithEffects = [
                    Rainfrost.SStack(OnCardPlayedDamageToNonRotAlliesInRow.Name, 4),
                    Rainfrost.SStack(TransformIntoMotherLongLegsOnCardPlayed.Name, 1),
                ];
                data.traits = [
                    Rainfrost.TStack(Rot.Name),
                    Rainfrost.TStack("Barrage")
                ];
            }
        )
    {
        public const string Name = "DaddyLongLegs";
    }
}