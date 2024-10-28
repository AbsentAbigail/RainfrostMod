using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

internal class PearlViridian() : AbstractItem(
    Name, "Viridian Pearl",
    attack: 0, needsTarget: true,
    pools: Pools.Clunkmaster,
    subscribe: data => data.traits =
    [
        AbsentUtils.TStack("Consume"),
        AbsentUtils.TStack("Aimless"),
        AbsentUtils.TStack(Pearl.Name)
    ])
{
    public const string Name = "ViridianPearl";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .SetAttackEffect(AbsentUtils.SStack("Haze"));
    }
}