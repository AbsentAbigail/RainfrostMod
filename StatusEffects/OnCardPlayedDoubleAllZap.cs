using AbsentUtilities;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedDoubleAllZap() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
    Name, "Double <ALL> {0}",
    effectToApply: InstantDoubleZap.Name,
    applyToFlags: ApplyToFlags.Allies | ApplyToFlags.Self | ApplyToFlags.Enemies | ApplyToFlags.Hand,
    subscribe: status => status.textInsert = $"<keyword={Keywords.Zap.Name}>"
)
{
    public const string Name = "On Card Played Double All Zap";
}