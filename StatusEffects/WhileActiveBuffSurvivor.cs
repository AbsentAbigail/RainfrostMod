using RainfrostMod.Helpers;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class WhileActiveBuffSurvivor() : AbstractApplyXStatus<StatusEffectWhileActiveX>(
        Name, null,
        true,
        effectToApply: OngoingIncreaseHealthAndAttack.Name, applyToFlags: ApplyToFlags.Allies,
        subscribe: status =>
        {
            status.applyConstraints = [
                TargetConstraintHelper.HasStatus(WhileActiveGiveSurvivorBuffToAllySlugcats.Name)
            ];
        })
    {
        public const string Name = "While Active Buff Survivor";
    }
}