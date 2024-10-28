using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class BrotherLongLegs() : AbstractCompanion(
    Name, "Brother Long Legs",
    8, 2, 4,
    Pools.None,
    data =>
    {
        data.startWithEffects =
        [
            AbsentUtils.SStack(TransformIntoDaddyLongLegsOnCardPlayed.Name)
        ];
        data.traits =
        [
            AbsentUtils.TStack(Rot.Name),
            AbsentUtils.TStack("Barrage")
        ];
    }
)
{
    public const string Name = "BrotherLongLegs";
}