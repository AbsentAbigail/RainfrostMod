using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class Spearmaster() : AbstractCompanion(
    Name, "Spearmaster",
    6, counter: 4,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(OnCardPlayedAddBoneNeedleToHand.Name, 2)
        ];

        card.traits =
        [
            AbsentUtils.TStack(Slugcat.Name)
        ];

        card.greetMessages = ["... (They gesture that they want to join you.)"];
    })
{
    public const string Name = "Spearmaster";
}