using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

internal class PearlBlack() : AbstractItem(
    Name, "Black Pearl",
    attack: 0, needsTarget: true,
    pools: Pools.Clunkmaster,
    subscribe: data => data.traits =
    [
        AbsentUtils.TStack("Consume"),
        AbsentUtils.TStack("Zoomlin"),
        AbsentUtils.TStack(Pearl.Name)
    ])
{
    public const string Name = "BlackPearl";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .SetAttackEffect(AbsentUtils.SStack("Null", 4));
    }
}