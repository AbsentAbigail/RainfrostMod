using AbsentUtilities;
using RainfrostMod.Keywords;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class WhileActiveAddMultiHitToAlliedSlugcats() : AbstractApplyXStatus<StatusEffectWhileActiveX>(
    Name, $"While active, add <x{{a}}><keyword=frenzy> to allied {Slugcat.Tag}",
    true, true,
    "MultiHit",
    ApplyToFlags.Allies,
    status => { status.applyConstraints = [TargetConstraintHelper.HasTrait(Traits.Slugcat.Name)]; })
{
    public const string Name = "While Active Add MultiHit To Allied Slugcats";
}