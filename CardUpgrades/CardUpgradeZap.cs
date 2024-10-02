using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.CardUpgrades
{
    internal class CardUpgradeZap() : AbstractCardUpgrade(
        Name, "Zap Charm",
        $"Apply <1><keyword={Keywords.Zap.Name}>",
        subscribe: charm =>
        {
            charm.attackEffects = [Rainfrost.SStack(Zap.Name, 1)];
            charm.targetConstraints = [
                TargetConstraintHelper.ApplyCharmConstraint(),
            ];
            charm.becomesTargetedCard = true;
        })
    {
        public const string Name = "CardUpgradeZap";
    }
}