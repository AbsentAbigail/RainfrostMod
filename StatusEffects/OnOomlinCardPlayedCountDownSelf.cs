using RainfrostMod.StatusEffects.Implementations;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class OnOomlinCardPlayedCountDownSelf() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayedWithTrait>(
        Name, "When a <keyword=noomlin> or <keyword=zoomlin> card is played, count down <keyword=counter> by <{a}>",
        true, true,
        "Reduce Counter",
        ApplyToFlags.Self,
        status => status.traits = [
            Rainfrost.TryGet<TraitData>("Zoomlin"),
            Rainfrost.TryGet<TraitData>("Noomlin"),
        ])
    {
        public const string Name = "On Oomlin Card Played Count Down Self";
    }
}