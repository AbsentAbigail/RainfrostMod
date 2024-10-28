using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class NoSignificantHarassment() : AbstractCompanion(
    Name, "No Significant Harassment",
    attack: 0, counter: 4,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack("Scrap", 2),
            AbsentUtils.SStack(OnCardPlayedAddNeuronFlyToHand.Name)
        ];
        card.traits =
        [
            AbsentUtils.TStack(Iterator.Name)
        ];
        card.greetMessages = ["Yo! Do you mind if I join y'all?"];
    }
)
{
    public const string Name = "NoSignificantHarassment";
}