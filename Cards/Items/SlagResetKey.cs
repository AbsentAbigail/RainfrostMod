using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items;

internal class SlagResetKey() : AbstractItem(
    Name, "Slag Reset Key",
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(OnCardPlayedSummonNeuronFlyToDiscardPile.Name, 5)
        ];
        card.traits =
        [
            AbsentUtils.TStack("Consume")
        ];
    })
{
    public const string Name = "SlagResetKey";
}