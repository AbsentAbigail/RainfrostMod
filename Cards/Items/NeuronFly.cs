using RainfrostMod.Helpers;

namespace RainfrostMod.Cards.Items
{
    internal class NeuronFly() : AbstractItem(
        Name, "Neuron Fly",
        needsTarget: true,
        playOnHand: true,
        subscribe: data =>
        {
            data.attackEffects = [
                Rainfrost.SStack("Instant Add Scrap", 1)
            ];

            data.traits = [
                Rainfrost.TStack("Consume"),
                Rainfrost.TStack("Zoomlin"),
            ];
        }
    )
    {
        public const string Name = "NeuronFly";
    }
}