using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class Monk() : AbstractUnit(
        Name, "Monk",
        3, 1, 4,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(OnCardPlayedIncreaseAttackOfAlliesInRow.Name, 1),
                Rainfrost.SStack(OnCardPlayedReduceAttackOfEnemiesInRow.Name, 1),
            ];

            card.traits = [
                Rainfrost.TStack(Slugcat.Name)
            ];

            card.greetMessages = ["Wa? Wawa! (It seems they want to join.)"];
        },
        altSprite: true)
    {
        public const string Name = "Monk";
    }
}