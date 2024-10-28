using AbsentUtilities;

namespace RainfrostMod.Cards.Items;

internal class Mushroom() : AbstractItem(
    Name, "Mushroom",
    needsTarget: true,
    pools: Pools.Snowdweller,
    subscribe: card =>
    {
        card.attackEffects =
        [
            AbsentUtils.SStack("Shroom", 2),
            AbsentUtils.SStack("Reduce Max Counter")
        ];
        card.traits =
        [
            AbsentUtils.TStack("Consume")
        ];
    })
{
    public const string Name = "Mushroom";
}