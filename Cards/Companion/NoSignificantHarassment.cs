using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class NoSignificantHarassment() : AbstractUnit(
            Name, "No Significant Harassment",
            attack: 0, counter: 4,
            subscribe: card =>
            {
                card.startWithEffects = [
                    Rainfrost.SStack("Scrap", 2),
                    Rainfrost.SStack(OnCardPlayedAddNeuronFlyToHand.Name, 1),
                ];
                card.traits = [
                    Rainfrost.TStack(Iterator.Name),
                ];
                card.greetMessages = ["Yo! Do you mind if I join y'all?"];
            }
        )
    {
        public const string Name = "NoSignificantHarassment";
    }
}