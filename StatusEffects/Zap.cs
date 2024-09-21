using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using WildfrostHopeMod.VFX;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class Zap() : AbstractApplyXStatus<StatusEffectApplyXPreTurn>(
        Name,
        canStack: true,
        canBoost: true,
        applyToFlags: ApplyToFlags.Self,
        subscribe: data =>
        {
            data.applyFormatKey = Rainfrost.GetStatus<StatusEffectData>("Shroom").applyFormatKey;
            data.dealDamage = true;
            data.countsAsHit = true;
            data.targetConstraints = [
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
                .WithIcon_VFX("zap", "zapicon", Keywords.Zap.Name, VFXMod_StatusEffectHelpers.LayoutGroup.health);
        }
    }
}