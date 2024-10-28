using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class Hunter() : AbstractCompanion(
    Name, "Hunter",
    6, 4, 3,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(WhenDestroyedTransformSelfIntoHunterLongLegs.Name),
            AbsentUtils.SStack("MultiHit")
        ];

        card.traits =
        [
            AbsentUtils.TStack(Slugcat.Name)
        ];

        card.greetMessages = ["Wawa... Wa? (They are thinking about joining you.)"];
    },
    altSprite: true)
{
    public const string Name = "Hunter";
}