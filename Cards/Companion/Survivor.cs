using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class Survivor() : AbstractUnit(
        Name, "Survivor",
        4, 3, 3,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(WhileActiveGiveSurvivorBuffToAllySlugcats.Name, 1)
            ];

            card.traits = [
                Rainfrost.TStack(Slugcat.Name)
            ];
        })
    {
        public const string Name = "Survivor";
    }
}