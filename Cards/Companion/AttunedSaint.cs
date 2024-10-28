using AbsentUtilities;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class AttunedSaint() : AbstractCompanion(
    Name, "Attuned Saint",
    2, 0, 2,
    Pools.None,
    card =>
    {
        card.attackEffects =
        [
            AbsentUtils.SStack("Kill")
        ];

        card.startWithEffects =
        [
            AbsentUtils.SStack("ImmuneToSnow")
        ];

        card.traits =
        [
            AbsentUtils.TStack(Slugcat.Name),
            AbsentUtils.TStack("Fragile")
        ];

        card.greetMessages = ["Wawa"];
    })
{
    public const string Name = "AttunedSaint";
}