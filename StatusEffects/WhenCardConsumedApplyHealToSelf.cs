using RainfrostMod.StatusEffects.Implementations;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class WhenCardConsumedApplyHealToSelf() : AbstractApplyXStatus<StatusEffectWhenAnyCardDestroyedApplyX>(
        Name,
        canStack: true,
        effectToApply: "Heal",
        applyToFlags: ApplyToFlags.Self,
        subscribe: status => status.consumed = true
        )
    {
        public const string Name = "When Card Consumed Apply Heal To Self";
    }
}