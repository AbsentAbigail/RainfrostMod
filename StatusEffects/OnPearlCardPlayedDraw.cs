using RainfrostMod.StatusEffects.Implementations;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class OnPearlCardPlayedDraw() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayedWithTrait>(
        Name, $"When a {Keywords.Pearl.Tag} card is played, <keyword=draw 2>",
        true, true,
        "Instant Draw",
        ApplyToFlags.Self,
        status => status.traits = [
            Rainfrost.TryGet<TraitData>(Traits.Pearl.Name),
        ])
    {
        public const string Name = "On Pearl Card Played Draw";
    }
}