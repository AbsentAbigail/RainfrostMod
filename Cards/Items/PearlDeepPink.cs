using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

public class PearlDeepPink() : AbstractItem(
    Name, "Deep Pink Pearl",
    needsTarget: true,
    subscribe: data => data.traits =
    [
        AbsentUtils.TStack("Zoomlin"),
        AbsentUtils.TStack("Consume"),
        AbsentUtils.TStack(Pearl.Name)
    ])
{
    public const string Name = "DeepPinkPearl";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .SetAttackEffect(AbsentUtils.SStack("Increase Max Health", 4));
    }
}