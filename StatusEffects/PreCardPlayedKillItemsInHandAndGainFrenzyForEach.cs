using AbsentUtilities;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class PreCardPlayedKillItemsInHandAndGainFrenzyForEach() : AbstractApplyXStatus<StatusEffectApplyXPreTrigger>(
    Name, "Before attacking, destroy all <Items> in hand and gain <x{a}><keyword=frenzy> for each",
    canStack: true, canBoost: true,
    effectToApply: InstantKillAndApplyMultiHitToApplier.Name,
    applyToFlags: ApplyToFlags.Hand,
    subscribe: status =>
    {
        status.applyConstraints = [TargetConstraintHelper.General<TargetConstraintIsItem>("Is Item")];
    })
{
    public const string Name = "Pre Card Played Kill Items In Hand And Gain Frenzy For Each";
}