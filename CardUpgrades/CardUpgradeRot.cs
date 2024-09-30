using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.CardUpgrades
{
    internal class CardUpgradeRot() : AbstractCardUpgrade(
        Name, "Cyst Charm",
        $"On kill, gain <+1><keyword=health> and <+1><keyword=attack>\nGain {Keywords.Rot.Tag}",
        subscribe: charm =>
        {
            charm.effects = [
                Rainfrost.SStack(OnKillGainAttackAndHealth.Name, 1),
            ];
            charm.giveTraits = [Rainfrost.TStack(Traits.Rot.Name)];
            charm.targetConstraints = [
                TargetConstraintHelper.HealthMoreThan(0),
                TargetConstraintHelper.General<TargetConstraintDoesDamage>("Does Damage"),
                TargetConstraintHelper.HasTrait(Traits.Rot.Name, not: true)
            ];
        })
    {
        public const string Name = "CardUpgradeRot";
    }
}