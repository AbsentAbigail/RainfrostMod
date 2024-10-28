using AbsentUtilities;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class InstantApplyFrenzyToApplier() : AbstractApplyXStatus<StatusEffectApplyXInstant>(
    Name,
    canStack: true,
    effectToApply: "MultiHit",
    applyToFlags: ApplyToFlags.Applier
)
{
    public const string Name = "Instant Apply MultiHit To Applier";
}