using AbsentUtilities;

namespace RainfrostMod.Cards.Items;

internal class EggbugEgg() : AbstractItem(
    Name, "Eggbug Egg",
    needsTarget: true,
    pools: Pools.None,
    subscribe: card =>
    {
        card.attackEffects = [AbsentUtils.SStack("Increase Max Health", 2)];
        card.traits =
        [
            AbsentUtils.TStack("Zoomlin"),
            AbsentUtils.TStack("Consume")
        ];
    })
{
    public const string Name = "EggbugEgg";
}