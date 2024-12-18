﻿using AbsentUtilities;
using RainfrostMod.Keywords;

namespace RainfrostMod.CardUpgrades;

internal class CardUpgradeBattery() : AbstractCardUpgrade(
    Name, "Battery Charm",
    $"Replace current <keyword=attack> with apply <keyword={Zap.Name}>",
    subscribe: charm =>
    {
        var replaceAttackWithZapScript =
            ScriptableHelper.CreateScriptable<CardScriptReplaceAttackWithApply>("Replace Attack With Zap");
        replaceAttackWithZapScript.effect = AbsentUtils.GetStatus(StatusEffects.Zap.Name);
        charm.scripts = [replaceAttackWithZapScript];

        charm.targetConstraints =
        [
            TargetConstraintHelper.General<TargetConstraintDoesDamage>("Does Damage")
        ];
    })
{
    public const string Name = "CardUpgradeBattery";
}