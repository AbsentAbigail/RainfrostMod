using AbsentUtilities;
using RainfrostMod.Keywords;

namespace RainfrostMod.CardUpgrades;

internal class CardUpgradeSlugcat() : AbstractCardUpgrade(
    Name, "Scug Charm",
    $"+1 <keyword=attack>\nGain {Slugcat.Tag}",
    subscribe: charm =>
    {
        charm.damage = 1;
        charm.giveTraits = [AbsentUtils.TStack(Traits.Slugcat.Name)];
        charm.targetConstraints = [TargetConstraintHelper.HealthMoreThan(0)];
    })
{
    public const string Name = "CardUpgradeSlugcat";
}