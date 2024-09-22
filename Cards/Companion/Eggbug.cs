using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion
{
    internal class Eggbug() : AbstractUnit(
        Name, "Eggbug",
        health: 4,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(WhenHitAddEggbugEggToHand.Name, 2),
            ];

            card.traits = [
                Rainfrost.TStack("Fragile"),
            ];
        })
    {
        public const string Name = "Eggbug";
    }
}