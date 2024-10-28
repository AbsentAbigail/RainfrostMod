using AbsentUtilities;
using RainfrostMod.Keywords;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedCountDownIteratorAllies() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
    Name, $"Count down <keyword=counter> {Iterator.Tag} allies by <{{a}}>",
    true, true,
    "Reduce Counter",
    ApplyToFlags.Allies,
    status => status.applyConstraints = [TargetConstraintHelper.HasTrait(Traits.Iterator.Name)])
{
    public const string Name = "On Card Played Count Down Iterator Allies";
}