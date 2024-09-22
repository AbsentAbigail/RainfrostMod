namespace RainfrostMod.StatusEffects
{
    internal class InstantKillAndApplyMultiHitToApplier() : AbstractStatus<StatusEffectInstantMultiple>(
        Name,
        canStack: true,
        subscribe: status =>
        {
            status.effects = [
                Rainfrost.GetStatus<StatusEffectInstant>("Kill"),
            ];
            status.applyXEffects = [
                Rainfrost.GetStatus<StatusEffectApplyXInstant>(InstantApplyFrenzyToApplier.Name),
            ];
        })
    {
        public const string Name = "Instant Kill And Apply MultiHit To Applier";
    }
}