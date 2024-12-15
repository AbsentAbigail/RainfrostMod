using AbsentUtilities;
using HarmonyLib;

namespace RainfrostMod.StatusEffects;

public class GainFrenzyWhenZapAppliedToEnemies() : AbstractApplyXStatus<StatusEffectApplyXWhenYAppliedTo>(
    Name, $"Whenever an enemy gains {Keywords.Zap.Tag}, gain <x{{a}}><keyword=frenzy>",
    canBoost: true,
    effectToApply: "MultiHit",
    subscribe: status =>
    {
        status.whenAppliedTypes = [AbsentUtils.GetStatus(Zap.Name).type];
        status.whenAppliedToFlags = StatusEffectApplyX.ApplyToFlags.Enemies;
    })
{
    public static string Name = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}