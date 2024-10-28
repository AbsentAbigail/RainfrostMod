using AbsentUtilities;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class HunterLongLegs() : AbstractCompanion(
    Name, "Hunter Long Legs",
    6, 4, 3,
    Pools.None,
    card =>
    {
        card.traits =
        [
            AbsentUtils.TStack(Rot.Name),
            AbsentUtils.TStack("Barrage")
        ];
    },
    true)
{
    public const string Name = "HunterLongLegs";
}