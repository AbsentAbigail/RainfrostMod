using RainfrostMod.Helpers;
using RainfrostMod.Keywords;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class WhileActiveGiveSurvivorBuffToAllySlugcats() : AbstractApplyXStatus<StatusEffectWhileActiveX>(
        Name, $"While active gain <{{a}}><keyword=health> and <keyword=attack> for each ally {KeywordHelper.Tag(Slugcat.Name)}",
        true, true,
        WhileActiveBuffSurvivor.Name, ApplyToFlags.Allies,
        status =>
        {
            status.applyConstraints = [
                TargetConstraintHelper.HasTrait(Traits.Slugcat.Name)
            ];
        })
    {
        public const string Name = "While Active Give Survivor Buff To Ally Slugcats";
    }
}