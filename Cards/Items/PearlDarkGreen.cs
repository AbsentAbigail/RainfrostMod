using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

internal class PearlDarkGreen() : AbstractItem(
    Name, "Dark Green Pearl",
    needsTarget: true,
    pools: Pools.None,
    subscribe: data => data.traits =
    [
        AbsentUtils.TStack("Consume"),
        AbsentUtils.TStack(Pearl.Name)
    ])
{
    public const string Name = "DarkGreenPearl";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .SetAttackEffect(AbsentUtils.SStack("Instant Gain Fury", 4));
    }
}