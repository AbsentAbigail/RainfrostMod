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
            charm.targetConstraints = [
                TargetConstraintHelper.General<TargetConstraintDoesAttack>("Does Attack"),
                TargetConstraintHelper.HasTrait(Traits.Slugcat.Name, not: true)
            ];
        })
    {
        public const string Name = "CardUpgradeSlugcat";
    }
}