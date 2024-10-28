using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class Saint() : AbstractCompanion(
    Name, "Saint",
    2, counter: 2,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(OnCardPlayedTransformIntoAttunedSaint.Name, 10),
            AbsentUtils.SStack("ImmuneToSnow")
        ];

        card.traits =
        [
            AbsentUtils.TStack(Slugcat.Name),
            AbsentUtils.TStack("Fragile")
        ];

        card.greetMessages = ["...? (They stare at you. Maybe they want to join?)"];
    })
{
    public const string Name = "Saint";
}