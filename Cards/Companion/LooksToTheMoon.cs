using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class LooksToTheMoon() : AbstractCompanion(
    "LooksToTheMoon", "Looks To The Moon",
    attack: 0, counter: 3,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack("Scrap", 2),
            AbsentUtils.SStack(OnCardPlayedAddRandomPearlToHand.Name)
        ];
        card.traits =
        [
            AbsentUtils.TStack(Iterator.Name)
        ];
        card.greetMessages = ["Hello little one! Can I join you?"];
    }
)
{
}