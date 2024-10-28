using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

internal class PearlBrightBlue() : AbstractItem(
    Name, "Bright Blue Pearl",
    attack: 0, needsTarget: true,
    subscribe: data => data.traits =
    [
        AbsentUtils.TStack("Consume"),
        AbsentUtils.TStack("Zoomlin"),
        AbsentUtils.TStack(Pearl.Name)
    ])
{
    public const string Name = "BrightBluePearl";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .SetAttackEffect(AbsentUtils.SStack("Snow", 3));
    }
}