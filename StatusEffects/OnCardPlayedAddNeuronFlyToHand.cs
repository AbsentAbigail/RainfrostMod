using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards;
using RainfrostMod.Cards.Items;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedAddNeuronFlyToHand() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(Name)
    {
        public const string Name = "On Card Played Add Neuron Fly To Hand";

        public override StatusEffectDataBuilder Builder()
        {
            return Rainfrost.StatusCopy("On Card Played Add Junk To Hand", Name)
                .WithText("Add <{a}> {0} to hand")
                .WithTextInsert(CardHelper.CardTag(NeuronFly.Name))
                .SubscribeToAfterAllBuildEvent(data =>
                    (data as StatusEffectApplyX).effectToApply = Rainfrost.GetStatus<StatusEffectData>(InstantSummonNeuronFly.Name)
                );
        }
    }
}