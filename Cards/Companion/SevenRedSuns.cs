using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion
{
    internal class SevenRedSuns() : AbstractUnit(
        Name, "Seven Red Suns",
        attack: 0, counter: 7,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack("Scrap", 2),
                Rainfrost.SStack(OnCardPlayedCountDownIteratorAllies.Name, 7),
            ];

            card.traits = [
                Rainfrost.TStack(Traits.Iterator.Name),
                Rainfrost.TStack("Spark"),
            ];
        })
    {
        public const string Name = "SevenRedSuns";
    }
}