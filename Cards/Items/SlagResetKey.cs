using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items
{
    internal class SlagResetKey() : AbstractItem(
        Name, "Slag Reset Key",
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(OnCardPlayedSummonNeuronFlyToDiscardPile.Name, 5),
            ];
            card.traits = [
                Rainfrost.TStack("Consume"),
            ];
        })
    {
        public const string Name = "SlagResetKey";
    }
}