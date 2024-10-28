using AbsentUtilities;
using RainfrostMod.Keywords;

namespace RainfrostMod.CardUpgrades;

internal class CardUpgradeZap() : AbstractCardUpgrade(
    Name, "Zap Charm",
    $"Apply <1><keyword={Zap.Name}>",
    subscribe: charm =>
    {
        charm.attackEffects = [AbsentUtils.SStack(StatusEffects.Zap.Name)];
        charm.targetConstraints =
        [
            TargetConstraintHelper.ApplyCharmConstraint()
        ];
        charm.becomesTargetedCard = true;
    })
{
    public const string Name = "CardUpgradeZap";
}