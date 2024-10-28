using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

internal class PearlBrightRed() : AbstractItem(
    Name, "Bright Red Pearl",
    needsTarget: true,
    pools: Pools.Snowdweller,
    subscribe: data => data.traits =
    [
        AbsentUtils.TStack("Consume"),
        AbsentUtils.TStack("Zoomlin"),
        AbsentUtils.TStack(Pearl.Name)
    ])
{
    public const string Name = "BrightRedPearl";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .SetAttackEffect(AbsentUtils.SStack("Spice", 3));
    }
}