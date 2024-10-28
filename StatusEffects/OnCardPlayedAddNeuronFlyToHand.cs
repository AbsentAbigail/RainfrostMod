using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Items;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedAddNeuronFlyToHand() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(Name)
{
    public const string Name = "On Card Played Add Neuron Fly To Hand";

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("On Card Played Add Junk To Hand", Name)
            .WithText("Add <{a}> {0} to hand")
            .WithTextInsert(AbstractCard.CardTag(NeuronFly.Name))
            .SubscribeToAfterAllBuildEvent(data =>
                ((StatusEffectApplyX)data).effectToApply = AbsentUtils.GetStatus(InstantSummonNeuronFly.Name)
            );
    }
}