using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items
{
    internal class Jellyfish() : AbstractItem(
        Name, "Jellyfish",
        0, true,
        subscribe: card =>
        {
            card.attackEffects = [Rainfrost.SStack(Zap.Name, 3)];
            card.startWithEffects = [Rainfrost.SStack(OnCardPlayedIncreaseAttackEffectToSelf.Name, 1)];
        })
    {
        public const string Name = "Jellyfish";
    }
}