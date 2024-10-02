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
                TargetConstraintHelper.General<TargetConstraintHasHealth>("Has Health"),
                TargetConstraintHelper.General<TargetConstraintDoesDamage>("Does Damage"),
            ];
        })
    {
        public const string Name = "CardUpgradeRot";
    }
}