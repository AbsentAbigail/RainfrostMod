using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

internal class PearlBrightGreen() : AbstractItem(
    Name, "Bright Green Pearl",
    attack: 0, needsTarget: true,
    pools: Pools.Snowdweller,
    subscribe: data => data.traits =
    [
        AbsentUtils.TStack("Consume"),
        AbsentUtils.TStack("Zoomlin"),
        AbsentUtils.TStack(Pearl.Name)
    ])
{
    public const string Name = "BrightGreenPearl";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .SetAttackEffect(AbsentUtils.SStack("Shroom", 3));
    }
}