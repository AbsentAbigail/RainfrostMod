using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.StatusEffects.Implementations;
using WildfrostHopeMod.VFX;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class Zap() : AbstractStatus<StatusEffectZap>(
    Name,
    canStack: true,
    subscribe: data =>
    {
        data.applyFormatKey = AbsentUtils.GetStatus("Shroom").applyFormatKey;
        data.removeOnDiscard = true;
        data.targetConstraints =
        [
            TargetConstraintHelper.General<TargetConstraintIsUnit>("Is Unit"),
            TargetConstraintHelper.HasCounterOrReaction()
        ];
    }
)
{
    public const string Name = "Zap";

    public override StatusEffectDataBuilder Builder()
    {
        return base.Builder()
            .WithTextInsert("{a}")
            .WithOffensive(true)
            .WithDoesDamage(true)
            .WithIcon_VFX("zap", "zap", Keywords.Zap.Name, VFXMod_StatusEffectHelpers.LayoutGroup.health);
    }
}