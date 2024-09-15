using Deadpan.Enums.Engine.Components.Modding;

namespace RainfrostMod.Cards.Items
{
    public class PearlDeepPink() : AbstractItem(
        Name, "Deep Pink Pearl",
        0, true,
        subscribe: data => data.traits = [
                Rainfrost.TStack("Zoomlin"),
                Rainfrost.TStack("Consume"),
                Rainfrost.TStack(Traits.Pearl.Name)
            ])
    {
        public const string Name = "DeepPinkPearl";

        public override CardDataBuilder Builder()
        {
            return base.Builder()
                .SetAttackEffect(Rainfrost.SStack("Increase Max Health", 4));
        }
    }
}