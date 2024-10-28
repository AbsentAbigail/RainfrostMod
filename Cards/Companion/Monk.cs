using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class Monk() : AbstractCompanion(
    Name, "Monk",
    3, 1, 4,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(OnCardPlayedIncreaseAttackOfAlliesInRow.Name),
            AbsentUtils.SStack(OnCardPlayedReduceAttackOfEnemiesInRow.Name)
        ];

        card.traits =
        [
            AbsentUtils.TStack(Slugcat.Name)
        ];

        card.greetMessages = ["Wa? Wawa! (It seems they want to join.)"];
    },
    altSprite: true)
{
    public const string Name = "Monk";
}