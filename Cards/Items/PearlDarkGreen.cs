using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items
{
    internal class PearlDarkGreen() : AbstractItem(
        Name, "Dark Green Pearl",
        0, true,
        subscribe: data => data.traits = [
            Rainfrost.TStack("Consume"),
            Rainfrost.TStack(Pearl.Name)
        ])
    {
        public const string Name = "DarkGreenPearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SetAttackEffect(Rainfrost.SStack("Instant Gain Fury", 4));
        }
    }
}