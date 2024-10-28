using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;

namespace RainfrostMod.StatusEffects;

internal class InstantGainExplode() : AbstractApplyXStatus<StatusEffectApplyXInstant>(Name)
{
    public const string Name = "Instant Gain Explode";

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("Instant Gain Aimless", Name)
            .WithKeyword("explode")
            .WithStackable(true)
            .WithCanBeBoosted(true)
            .WithText("Add <keyword=explode {a}> to the target")
            .SubscribeToAfterAllBuildEvent(
                data =>
                {
                    var status = data as StatusEffectApplyXInstant;
                    status.effectToApply = AbsentUtils.GetStatus(TemporaryExplode.Name);
                    status.targetConstraints = [TargetConstraintHelper.General<TargetConstraintIsUnit>("Is Alive")];
                });
    }
}