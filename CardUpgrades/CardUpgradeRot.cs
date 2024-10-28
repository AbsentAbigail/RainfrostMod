using AbsentUtilities;
using RainfrostMod.Keywords;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.CardUpgrades;

internal class CardUpgradeRot() : AbstractCardUpgrade(
    Name, "Cyst Charm",
    $"On kill, gain <+1><keyword=health> and <+1><keyword=attack>\nGain {Rot.Tag}",
    subscribe: charm =>
    {
        charm.effects =
        [
            AbsentUtils.SStack(OnKillGainAttackAndHealth.Name)
        ];
        charm.giveTraits = [AbsentUtils.TStack(Traits.Rot.Name)];
        charm.targetConstraints =
        [
            TargetConstraintHelper.General<TargetConstraintHasHealth>("Has Health"),
            TargetConstraintHelper.General<TargetConstraintDoesDamage>("Does Damage")
        ];
    })
{
    public const string Name = "CardUpgradeRot";
}