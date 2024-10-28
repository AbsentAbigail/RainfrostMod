using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Items;

internal class PearlGold() : AbstractItem(
    Name, "Gold Pearl",
    attack: 0, needsTarget: true,
    pools: Pools.None,
    subscribe: data => data.traits =
    [
        AbsentUtils.TStack("Consume"),
        AbsentUtils.TStack(Pearl.Name)
    ])
{
    public const string Name = "GoldPearl";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .SetAttackEffect(AbsentUtils.SStack("Gain Gold", 4))
            .WithText("Gain <{a}> <keyword=blings>");
    }
}