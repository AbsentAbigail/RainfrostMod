using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedTriggerAgainstAllAllies()
    : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(Name)
{
    public static string Name = AccessTools.GetOutsideCaller().DeclaringType!.Name;

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("On Card Played Trigger Against AllyBehind", Name)
            .WithText("Also hits all allies")
            .SubscribeToAfterAllBuildEvent(data =>
            {
                var status = (StatusEffectApplyXOnCardPlayed)data;
                status.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies;
            });
    }
}