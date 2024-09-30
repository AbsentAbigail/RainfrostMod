using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items
{
    internal class PearlDarkMagenta() : AbstractItem(
        Name, "Dark Magenta Pearl",
        0, true,
        pools: Pools.None,
        subscribe: data => data.traits = [
            Rainfrost.TStack("Consume"),
            Rainfrost.TStack("Zoomlin"),
            Rainfrost.TStack("Barrage"),
            Rainfrost.TStack(Pearl.Name)
        ])
    {
        public const string Name = "DarkMagentaPearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SetAttackEffect(Rainfrost.SStack("Frost", 3));
        }
    }
}