using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items
{
    internal class PearlGold() : AbstractItem(
        Name, "Gold Pearl",
        0, true,
        subscribe: data => data.traits = [
            Rainfrost.TStack("Consume"),
            Rainfrost.TStack(Pearl.Name)
        ])
    {
        public const string Name = "GoldPearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SetAttackEffect(Rainfrost.SStack("Gain Gold", 4))
                .WithText("Gain <{a}> <keyword=blings>");
        }
    }
}