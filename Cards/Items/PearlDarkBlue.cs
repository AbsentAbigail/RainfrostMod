using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items
{
    internal class PearlDarkBlue() : AbstractItem(
        Name, "Dark Blue Pearl",
        0, true,
        pools: Pools.None,
        subscribe: data => data.traits = [
            Rainfrost.TStack("Consume"),
            Rainfrost.TStack(Pearl.Name)
        ])
    {
        public const string Name = "DarkBluePearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SubscribeToAfterAllBuildEvent(data => data.attackEffects = [Rainfrost.SStack(InstantGainExplode.Name, 4)]);
        }
    }
}