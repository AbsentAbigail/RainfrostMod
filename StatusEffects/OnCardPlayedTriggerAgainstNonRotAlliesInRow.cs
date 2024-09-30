using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedTriggerAgainstNonRotAlliesInRow() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(Name)
    {
        public const string Name = "On Card Played Trigger Against Non Rot AlliesInRow";

        public override StatusEffectDataBuilder Builder()
        {
            return Rainfrost.StatusCopy("On Card Played Trigger Against AllyBehind", Name)
                .SubscribeToAfterAllBuildEvent(data =>
                {
                    var status = data as StatusEffectApplyXOnCardPlayed;
                    status.textKey = null;
                    status.applyToFlags = StatusEffectApplyX.ApplyToFlags.AlliesInRow;
                    status.applyConstraints = [
                        TargetConstraintHelper.HasTrait(Traits.Rot.Name, not: true)
                    ];
                });
        }
    }
}