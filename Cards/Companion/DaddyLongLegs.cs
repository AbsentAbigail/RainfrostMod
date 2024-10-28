using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class DaddyLongLegs() : AbstractCompanion(
    Name, "Daddy Long Legs",
    10, 4, 4,
    Pools.None,
    data =>
    {
        data.startWithEffects =
        [
            AbsentUtils.SStack(TransformIntoMotherLongLegsOnCardPlayed.Name)
        ];
        data.traits =
        [
            AbsentUtils.TStack(Rot.Name),
            AbsentUtils.TStack("Barrage")
        ];
    }
)
{
    public const string Name = "DaddyLongLegs";
}