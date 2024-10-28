using AbsentUtilities;

namespace RainfrostMod.StatusEffects;

internal class TemporaryExplode() : AbstractStatus<StatusEffectTemporaryTrait>(
    Name,
    subscribe: data => data.trait = AbsentUtils.GetTrait("Explode")
)
{
    public const string Name = "Temporary Explode";
}