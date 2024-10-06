using RainfrostMod.Helpers;

namespace RainfrostMod.CardUpgrades
{
    internal class CardUpgradeSlugcat() : AbstractCardUpgrade(
        Name, "Scug Charm",
        $"+1 <keyword=attack>\nGain {Keywords.Slugcat.Tag}",
        subscribe: charm =>
        {
            charm.damage = 1;
            charm.giveTraits = [Rainfrost.TStack(Traits.Slugcat.Name)];
            charm.targetConstraints = [TargetConstraintHelper.HealthMoreThan(0)];
        })
    {
        public const string Name = "CardUpgradeSlugcat";
    }
}