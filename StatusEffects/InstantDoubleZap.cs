namespace RainfrostMod.StatusEffects
{
    internal class InstantDoubleZap() : AbstractStatus<StatusEffectInstantDoubleX>(
        Name,
        subscribe: status => {
            status.statusToDouble = Rainfrost.GetStatus<StatusEffectData>(Zap.Name);
            status.countsAsHit = false;
        })
    {
        public const string Name = "Instant Double Zap";
    }
}