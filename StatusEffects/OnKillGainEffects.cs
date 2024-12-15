using AbsentUtilities;
using HarmonyLib;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class OnKillGainEffects() : AbstractApplyXStatus<StatusEffectApplyXOnKill>(
    Name, "On Kill, steal effects and status effects",
    effectToApply: InstantEatEffects.Name,
    applyToFlags: ApplyToFlags.Target, subscribe:
    status =>
    {
        status.targetMustBeAlive = false;
    })
{
    public static string Name = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}
