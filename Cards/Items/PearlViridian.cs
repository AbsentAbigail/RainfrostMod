using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items
{
    internal class PearlViridian() : AbstractItem(
        Name, "Viridian Pearl",
        0, true,
        Pools.Clunkmaster,
        subscribe: data => data.traits = [
            Rainfrost.TStack("Consume"),
            Rainfrost.TStack("Aimless"),
            Rainfrost.TStack(Pearl.Name)
        ])
    {
        public const string Name = "ViridianPearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SetAttackEffect(Rainfrost.SStack("Haze", 1));
        }
    }
}