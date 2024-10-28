using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

internal class PearlTeal() : AbstractItem(
    Name, "Teal Pearl",
    attack: 0, needsTarget: true,
    pools: Pools.Shademancer,
    subscribe: data => data.traits =
    [
        AbsentUtils.TStack("Consume"),
        AbsentUtils.TStack("Zoomlin"),
        AbsentUtils.TStack("Barrage"),
        AbsentUtils.TStack(Pearl.Name)
    ])
{
    public const string Name = "TealPearl";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .SetAttackEffect(AbsentUtils.SStack("Overload", 2));
    }
}