using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items
{
    internal class PearlLightBlue() : AbstractItem(
        Name, "Light Blue Pearl",
        0, true,
        subscribe: data => data.traits = [
            Rainfrost.TStack("Consume"),
            Rainfrost.TStack(Pearl.Name)
        ])
    {
        public const string Name = "LightBluePearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SetAttackEffect(Rainfrost.SStack("Increase Attack", 3));
        }
    }
}