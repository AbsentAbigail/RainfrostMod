using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Keywords;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedAddRandomPearlToHand() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(Name)
{
    public const string Name = "On Card Played Add Random Pearl To Hand";

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("On Card Played Add Junk To Hand", Name)
            .WithText($"Add <{{a}}> random {Pearl.Tag} Card(s) to hand")
            .SubscribeToAfterAllBuildEvent(data =>
                ((StatusEffectApplyX)data).effectToApply = AbsentUtils.GetStatus(InstantSummonRandomPearl.Name)
            );
    }
}