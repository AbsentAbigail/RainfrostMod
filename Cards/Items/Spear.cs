using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;

namespace RainfrostMod.Cards.Items;

internal class Spear() : AbstractItem(
    Name, "Spear",
    5, true,
    subscribe: card => card.traits = [AbsentUtils.TStack("Zoomlin")])
{
    public const string Name = "Spear";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .WithFlavour("metal_pipe.sfx");
    }
}