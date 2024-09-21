using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion
{
    internal class SliverOfStraw() : AbstractUnit(
        Name, "Sliver of Straw",
        attack: 0, counter: 4,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack("Scrap", 2),
                Rainfrost.SStack(OnCardPlayedDoubleAllZap.Name),
            ];
            card.attackEffects = [
                Rainfrost.SStack(Zap.Name, 1),
            ];
            card.traits = [
                Rainfrost.TStack(Traits.Iterator.Name),
            ];
        })
    {
        public const string Name = "SliverOfStraw";
    }
}