using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

internal class PearlWhite() : AbstractItem(
    Name, "White Pearl",
    needsTarget: true,
    pools: Pools.Shademancer,
    subscribe: data => data.traits =
    [
        AbsentUtils.TStack("Consume"),
        AbsentUtils.TStack(Pearl.Name)
    ])
{
    public const string Name = "WhitePearl";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .SetAttackEffect(AbsentUtils.SStack("Teeth", 3));
    }
}