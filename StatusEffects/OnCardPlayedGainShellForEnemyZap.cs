using AbsentUtilities;
using HarmonyLib;
using RainfrostMod.StatusEffects.Scriptables;

namespace RainfrostMod.StatusEffects;

public class OnCardPlayedGainShellForEnemyZap() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
    Name, "Gain <keyword=shell> equal to all enemy " + Keywords.Zap.Tag, effectToApply: "Shell",
    subscribe: status =>
    {
        status.scriptableAmount = ScriptableHelper.CreateScriptable<ScriptableStatusOnBoard>("Zap on enemies", 
        s =>
        {
            s.statusType = AbsentUtils.GetStatus(Zap.Name).type;
            s.count = true;
            s.enemies = true;
        });
    })
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}