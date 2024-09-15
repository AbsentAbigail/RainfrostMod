using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items
{
    internal class PearlBrightGreen() : AbstractItem(
        Name, "Bright Green Pearl",
        0, true,
        Pools.Snowdweller,
        subscribe: data => data.traits = [
            Rainfrost.TStack("Consume"),
            Rainfrost.TStack("Zoomlin"),
            Rainfrost.TStack(Pearl.Name)
        ])
    {
        public const string Name = "BrightGreenPearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SetAttackEffect(Rainfrost.SStack("Shroom", 3));
        }
    }
}