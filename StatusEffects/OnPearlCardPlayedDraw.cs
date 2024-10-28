using AbsentUtilities;
using RainfrostMod.Keywords;
using RainfrostMod.StatusEffects.Implementations;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class OnPearlCardPlayedDraw() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayedWithTrait>(
    Name, $"When a {Pearl.Tag} card is played, <keyword=draw 2>",
    true, true,
    "Instant Draw",
    ApplyToFlags.Self,
    status => status.traits =
    [
        AbsentUtils.GetTrait(Traits.Pearl.Name)
    ])
{
    public const string Name = "On Pearl Card Played Draw";
}