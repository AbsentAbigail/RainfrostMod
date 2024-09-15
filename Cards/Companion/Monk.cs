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
                Rainfrost.SStack("While Active Increase Attack To AlliesInRow", 1),
                Rainfrost.SStack(WhileActiveReduceAttackToEnemiesInRow.Name, 1),
            ];

            card.traits = [
                Rainfrost.TStack(Slugcat.Name)
            ];
        })
    {
        public const string Name = "Monk";
    }
}