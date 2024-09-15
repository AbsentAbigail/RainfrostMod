using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards;
using RainfrostMod.Cards.Items;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedSummonNeuronFlyToDiscardPile() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
        Name, "Add <{a}> {0} to <discard pile>",
        true, true,
        InstantSummonNeuronFlyToDiscardPile.Name,
        ApplyToFlags.Self
        )
    {
        public const string Name = "On Card Played Summon Neuron Fly To Discard Pile";

        public override StatusEffectDataBuilder Builder()
        {
            return base.Builder()
                .WithTextInsert(CardHelper.CardTag(NeuronFly.Name));
        }
    }
}