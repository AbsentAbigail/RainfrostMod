using RainfrostMod.Helpers;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class WhileActiveAddMultiHitToAllPearls() : AbstractApplyXStatus<StatusEffectWhileActiveX>(
        Name, $"While active, add <x{{a}}><keyword=frenzy> to all {Keywords.Pearl.Tag} cards",
        true, true,
        "MultiHit",
        ApplyToFlags.Self | ApplyToFlags.Allies | ApplyToFlags.Enemies | ApplyToFlags.Hand,
        status =>
        {
            status.applyConstraints = [TargetConstraintHelper.HasTrait(Traits.Pearl.Name)];
        })
    {
        public const string Name = "While Active Add MultiHit To All Pearls";
    }
}