using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items
{
    internal class PearlWhite() : AbstractItem(
        Name, "White Pearl",
        0, true,
        Pools.Shademancer,
        subscribe: data => data.traits = [
            Rainfrost.TStack("Consume"),
            Rainfrost.TStack(Pearl.Name)
        ])
    {
        public const string Name = "WhitePearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SetAttackEffect(Rainfrost.SStack("Teeth", 3));
        }
    }
}