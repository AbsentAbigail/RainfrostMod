using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items
{
    internal class PearlTeal() : AbstractItem(
        Name, "Teal Pearl",
        0, true,
        Pools.Shademancer,
        subscribe: data => data.traits = [
            Rainfrost.TStack("Consume"),
            Rainfrost.TStack("Zoomlin"),
            Rainfrost.TStack("Barrage"),
            Rainfrost.TStack(Pearl.Name)
        ])
    {
        public const string Name = "TealPearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SetAttackEffect(Rainfrost.SStack("Overload", 2));
        }
    }
}