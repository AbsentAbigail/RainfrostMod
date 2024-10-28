using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class Survivor() : AbstractCompanion(
    Name, "Survivor",
    4, 3, 3,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(OnCardPlayedIncreaseHealthAndAttackForEachAlliedSlugcat.Name)
        ];

        card.traits =
        [
            AbsentUtils.TStack(Slugcat.Name)
        ];

        card.greetMessages = ["Wawa? (It seems they are asking to join.)"];
    },
    altSprite: true)
{
    public const string Name = "Survivor";
}