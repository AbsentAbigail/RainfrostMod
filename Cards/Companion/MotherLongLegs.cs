using AbsentUtilities;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class MotherLongLegs() : AbstractCompanion(
    Name, "Mother Long Legs",
    12, 6, 4,
    Pools.None,
    data =>
    {
        data.startWithEffects =
        [
            AbsentUtils.SStack("When X Health Lost Split", 3)
        ];
        data.traits =
        [
            AbsentUtils.TStack(Rot.Name),
            AbsentUtils.TStack("Barrage")
        ];
    }
)
{
    public const string Name = "MotherLongLegs";
}