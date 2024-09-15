using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class NoSignificantHarassment() : AbstractUnit(
            Name, "No Significant Harassment",
            attack: 0, counter: 4,
            subscribe: data =>
            {
                data.startWithEffects = [
                    Rainfrost.SStack("Scrap", 2),
                    Rainfrost.SStack(OnCardPlayedAddNeuronFlyToHand.Name, 1),
                ];
                data.traits = [
                    Rainfrost.TStack(Iterator.Name),
                ];
            }
        )
    {
        public const string Name = "NoSignificantHarassment";
    }
}