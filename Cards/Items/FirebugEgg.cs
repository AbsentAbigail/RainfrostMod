using AbsentUtilities;

namespace RainfrostMod.Cards.Items;

internal class FirebugEgg() : AbstractItem(
    Name, "Firebug Egg",
    0, true,
    Pools.None,
    subscribe: card =>
    {
        card.attackEffects = [AbsentUtils.SStack("Overload", 3)];
        card.traits =
        [
            AbsentUtils.TStack("Zoomlin"),
            AbsentUtils.TStack("Consume")
        ];
    })
{
    public const string Name = "FirebugEgg";
}