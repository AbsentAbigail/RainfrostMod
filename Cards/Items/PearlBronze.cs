using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

internal class PearlBronze() : AbstractItem(
    Name, "Bronze Pearl",
    attack: 0, needsTarget: true,
    pools: Pools.Clunkmaster,
    subscribe: card =>
    {
        card.traits =
        [
            AbsentUtils.TStack("Consume"),
            AbsentUtils.TStack("Zoomlin"),
            AbsentUtils.TStack(Pearl.Name)
        ];
        card.attackEffects = [AbsentUtils.SStack("Weakness", 4)];
    })
{
    public const string Name = "BronzePearl";
}