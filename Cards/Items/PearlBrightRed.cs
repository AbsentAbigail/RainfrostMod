
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items
{
    internal class PearlBrightRed() : AbstractItem(
        Name, "Bright Red Pearl",
        0, true,
        Pools.Snowdweller,
        subscribe: data => data.traits = [
            Rainfrost.TStack("Consume"),
            Rainfrost.TStack("Zoomlin"),
            Rainfrost.TStack(Pearl.Name)
        ])
    {
        public const string Name = "BrightRedPearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SetAttackEffect(Rainfrost.SStack("Spice", 3));
        }
    }
}