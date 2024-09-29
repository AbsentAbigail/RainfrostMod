using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using RainfrostMod.Keywords;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedTakeHealthFromNonRotAllies() : AbstractStatus<StatusEffectApplyXOnCardPlayed>(Name)
    {
        public const string Name = "On Card Played Take Health From Non Rot Allies";

        public override StatusEffectDataBuilder Builder()
        {
            return Rainfrost.StatusCopy("On Card Played Take Health From Allies", Name)
                .WithText($"Take <{{a}}><keyword=health> from all non-{Rot.Tag} allies")
                .SubscribeToAfterAllBuildEvent(data =>
                {
                    var status = data as StatusEffectApplyX;
                    status.applyConstraints = [TargetConstraintHelper.HasTrait(Traits.Rot.Name, not: true)];
                });
        }
    }
}