using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedApplySpiceToCardsInHand() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
        Name, "Apply <{a}><keyword=spice> to cards in hand",
        canStack: true, canBoost: true,
        effectToApply: "Spice",
        applyToFlags: ApplyToFlags.Hand
        )
    {
        public const string Name = "On Card Played Apply Spice To Cards In Hand";
    }
}