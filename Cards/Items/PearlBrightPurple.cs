using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items
{
    internal class PearlBrightPurple() : AbstractItem(
        Name, "Bright Purple Pearl",
        0, true,
        subscribe: data => data.traits = [
            Rainfrost.TStack("Consume"),
            Rainfrost.TStack("Zoomlin"),
            Rainfrost.TStack(Pearl.Name)
        ])
    {
        public const string Name = "BrightPurplePearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SetAttackEffect(Rainfrost.SStack("Demonize", 1));
        }
    }
}