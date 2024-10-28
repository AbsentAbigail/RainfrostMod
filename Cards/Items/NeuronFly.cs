using AbsentUtilities;

namespace RainfrostMod.Cards.Items;

internal class NeuronFly() : AbstractItem(
    Name, "Neuron Fly",
    needsTarget: true,
    playOnHand: true,
    subscribe: data =>
    {
        data.attackEffects =
        [
            AbsentUtils.SStack("Instant Add Scrap")
        ];

        data.traits =
        [
            AbsentUtils.TStack("Consume"),
            AbsentUtils.TStack("Zoomlin")
        ];
    }
)
{
    public const string Name = "NeuronFly";
}