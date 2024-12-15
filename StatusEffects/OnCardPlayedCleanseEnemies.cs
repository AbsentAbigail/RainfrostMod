using AbsentUtilities;
using HarmonyLib;

namespace RainfrostMod.StatusEffects;

public class OnCardPlayedCleanseEnemies() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
    Name, "<keyword=cleanse> all enemies", effectToApply: "Cleanse",
    applyToFlags: StatusEffectApplyX.ApplyToFlags.Enemies,
    subscribe: status => status.eventPriority = -1)
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}