using AbsentUtilities;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

internal class SingularityBomb() : AbstractItem(
    Name, "Singularity Bomb",
    20, true,
    Pools.None,
    subscribe: card =>
    {
        card.traits =
        [
            AbsentUtils.TStack(Nuke.Name),
            AbsentUtils.TStack("Consume")
        ];
    })
{
    public const string Name = "SingularityBomb";
}