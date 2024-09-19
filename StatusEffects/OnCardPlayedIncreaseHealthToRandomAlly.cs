using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedIncreaseHealthToRandomAlly() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
        Name,
        canStack: true, canBoost: true,
        effectToApply: "Increase Max Health",
        applyToFlags: ApplyToFlags.RandomAlly)
    {
        public const string Name = "On Card Played Increase Health To RandomAlly";
    }
}