using System.Reflection;
using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Items;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedSummonNeuronFlyToDiscardPile() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
    Name, "Add <{a}> {0} to <discard pile>",
    true, true,
    InstantSummonNeuronFlyToDiscardPile.Name,
    subscribe: status => status.textInsert = CardHelper.CardTag(NeuronFly.Name)
)
{
    public const string Name = "On Card Played Summon Neuron Fly To Discard Pile";
}