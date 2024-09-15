using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items
{
    internal class PearlBlack() : AbstractItem(
        Name, "Black Pearl",
        0, true,
        Pools.Clunkmaster,
        subscribe: data => data.traits = [
            Rainfrost.TStack("Consume"),
            Rainfrost.TStack("Zoomlin"),
            Rainfrost.TStack(Pearl.Name)
        ])
    {
        public const string Name = "BlackPearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SetAttackEffect(Rainfrost.SStack("Null", 4));
        }
    }
}