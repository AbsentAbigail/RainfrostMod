using AbsentUtilities;

namespace RainfrostMod.StatusEffects;

internal class InstantDoubleZap() : AbstractStatus<StatusEffectInstantDoubleX>(
    Name,
    subscribe: status =>
    {
        status.statusToDouble = AbsentUtils.GetStatus(Zap.Name);
        status.countsAsHit = false;
    })
{
    public const string Name = "Instant Double Zap";
}