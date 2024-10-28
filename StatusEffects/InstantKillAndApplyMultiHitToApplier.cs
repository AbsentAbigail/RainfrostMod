using AbsentUtilities;

namespace RainfrostMod.StatusEffects;

internal class InstantKillAndApplyMultiHitToApplier() : AbstractStatus<StatusEffectInstantMultiple>(
    Name,
    canStack: true,
    subscribe: status =>
    {
        status.effects =
        [
            AbsentUtils.GetStatusOf<StatusEffectInstant>("Kill")
        ];
        status.applyXEffects =
        [
            AbsentUtils.GetStatusOf<StatusEffectApplyXInstant>(InstantApplyFrenzyToApplier.Name)
        ];
    })
{
    public const string Name = "Instant Kill And Apply MultiHit To Applier";
}