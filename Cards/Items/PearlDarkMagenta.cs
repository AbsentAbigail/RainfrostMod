using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

internal class PearlDarkMagenta() : AbstractItem(
    Name, "Dark Magenta Pearl",
    attack: 0, needsTarget: true,
    pools: Pools.None,
    subscribe: data => data.traits =
    [
        AbsentUtils.TStack("Consume"),
        AbsentUtils.TStack("Zoomlin"),
        AbsentUtils.TStack("Barrage"),
        AbsentUtils.TStack(Pearl.Name)
    ])
{
    public const string Name = "DarkMagentaPearl";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .SetAttackEffect(AbsentUtils.SStack("Frost", 3));
    }
}