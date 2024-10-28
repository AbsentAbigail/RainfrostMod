using AbsentUtilities;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedSummonCopyOfLeftmostCardInHand() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
    Name, "Make a copy of the leftmost <Item> in your hand",
    effectToApply: "Instant Summon Copy Of Item",
    applyToFlags: ApplyToFlags.Hand,
    subscribe: status => status.applyConstraints =
        [TargetConstraintHelper.General<TargetConstraintLeftmostItemInHand>("Leftmost Card In Hand")])
{
    public const string Name = "On Card Played Summon Copy of Leftmost Card In Hand";
}