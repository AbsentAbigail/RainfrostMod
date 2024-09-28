using RainfrostMod.Helpers;
using RainfrostMod.Keywords;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedDamageToNonRotAlliesInRow() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
        Name, $"Deal <{{a}}> damage to non-{KeywordHelper.Tag(Rot.Name)} allies in row",
        true, true,
        applyToFlags: ApplyToFlags.AlliesInRow,
        subscribe: status =>
        {
            status.applyConstraints = [
                TargetConstraintHelper.HasTrait(Traits.Rot.Name, not: true)
            ];

            status.dealDamage = true;
            status.doesDamage = true;
            status.countsAsHit = true;
        })
    {
        public const string Name = "On Card Played Deal Damage To Non Rot Allies In Row";
    }
}