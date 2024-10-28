using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

internal class PearlDarkBlue() : AbstractItem(
    Name, "Dark Blue Pearl",
    needsTarget: true,
    pools: Pools.None,
    subscribe: data => data.traits =
    [
        AbsentUtils.TStack("Consume"),
        AbsentUtils.TStack(Pearl.Name)
    ])
{
    public const string Name = "DarkBluePearl";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .SubscribeToAfterAllBuildEvent(
                data => data.attackEffects = [AbsentUtils.SStack(InstantGainExplode.Name, 4)]);
    }
}