using RainfrostMod.Helpers;
using RainfrostMod.Keywords;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedDamageToNonRotAlliesInRow() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
        Name, $"Deal <{{a}}> damage to non-{KeywordHelper.Tag(Rot.Name)} allies in row",
        true, true,
        applyToFlags: ApplyToFlags.AlliesInRow,
        subscribe: data =>
        {
            data.applyConstraints = [
                TargetConstraintHelper.HasTrait(Traits.Rot.Name, not: true)
            ];
            data.dealDamage = true;
            data.doesDamage = true;
            data.countsAsHit = true;
        })
    {
        public const string Name = "On Card Played Deal Damage To Non Rot Allies In Row";
    }
}