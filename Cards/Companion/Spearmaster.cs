using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class Spearmaster() : AbstractUnit(
        Name, "Spearmaster",
        health: 6, counter: 4,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(OnCardPlayedAddBoneNeedleToHand.Name, 2),
            ];

            card.traits = [
                Rainfrost.TStack(Slugcat.Name),
            ];

            card.greetMessages = ["... (They gesture that they want to join you.)"];
        })
    {
        public const string Name = "Spearmaster";
    }
}