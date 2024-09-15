using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items
{
    internal class PearlBrightBlue() : AbstractItem(
        Name, "Bright Blue Pearl",
        0, true,
        subscribe: data => data.traits = [
            Rainfrost.TStack("Consume"),
            Rainfrost.TStack("Zoomlin"),
            Rainfrost.TStack(Pearl.Name)
        ])
    {
        public const string Name = "BrightBluePearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SetAttackEffect(Rainfrost.SStack("Snow", 3));
        }
    }
}