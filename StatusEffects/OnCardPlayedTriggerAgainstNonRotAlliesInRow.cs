using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedTriggerAgainstNonRotAlliesInRow()
    : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(Name)
{
    public const string Name = "On Card Played Trigger Against Non Rot AlliesInRow";

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("On Card Played Trigger Against AllyBehind", Name)
            .SubscribeToAfterAllBuildEvent(data =>
            {
                var status = (StatusEffectApplyXOnCardPlayed)data;
                status.textKey = null;
                status.applyToFlags = StatusEffectApplyX.ApplyToFlags.AlliesInRow;
                status.applyConstraints =
                [
                    TargetConstraintHelper.HasTrait(Rot.Name, not: true)
                ];
            });
    }
}