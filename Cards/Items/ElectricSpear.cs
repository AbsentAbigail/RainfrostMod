using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items
{
    internal class ElectricSpear() : AbstractItem(
        Name, "Electric Spear",
        3, true,
        subscribe: card =>
        {
            card.attackEffects = [Rainfrost.SStack(Zap.Name, 4)];
            card.startWithEffects = [Rainfrost.SStack("On Card Played Reduce Attack Effect 1 To Self", 1)];
        })
    {
        public const string Name = "ElectricSpear";
    }
}