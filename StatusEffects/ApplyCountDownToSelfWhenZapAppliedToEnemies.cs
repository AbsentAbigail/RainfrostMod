using AbsentUtilities;
using HarmonyLib;

namespace RainfrostMod.StatusEffects;

public class ApplyCountDownToSelfWhenZapAppliedToEnemies() : AbstractApplyXStatus<StatusEffectApplyXWhenYAppliedTo>(
    Name, $"Whenever an enemy gains {Keywords.Zap.Tag}, count down own <keyword=counter> by <{{a}}>",
    canBoost: true,
    effectToApply: "Reduce Counter",
    subscribe: status =>
    {
        status.whenAppliedTypes = [AbsentUtils.GetStatus(Zap.Name).type];
        status.whenAppliedToFlags = StatusEffectApplyX.ApplyToFlags.Enemies;
    })
{
    public static string Name = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}