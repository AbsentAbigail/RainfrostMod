using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;

namespace RainfrostMod.StatusEffects
{
    internal class InstantGainExplode() : AbstractApplyXStatus<StatusEffectApplyXInstant>(Name)
    {
        public const string Name = "Instant Gain Explode";

        public override StatusEffectDataBuilder Builder()
        {
            return Rainfrost.StatusCopy("Instant Gain Aimless", Name)
                .WithKeyword("explode")
                .WithStackable(true)
                .WithCanBeBoosted(true)
                .WithText("Add <keyword=explode {a}> to the target")
                .SubscribeToAfterAllBuildEvent(
                data => {
                    var status = data as StatusEffectApplyXInstant;
                    status.effectToApply = Rainfrost.GetStatus<StatusEffectData>(TemporaryExplode.Name);
                    status.targetConstraints = [TargetConstraintHelper.General<TargetConstraintIsUnit>("Is Alive")];
                });
        }
    }
}