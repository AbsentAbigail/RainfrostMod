using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items
{
    internal class Hazer() : AbstractItem(
        Name, "Hazer",
        0, true,
        subscribe: card =>
        {
            card.attackEffects = [
                Rainfrost.SStack("Haze", 1),
            ];

            card.startWithEffects = [
                Rainfrost.SStack(OnCardPlayedApplyNullToRandomAlly.Name, 4),
            ];
        })
    {
        public const string Name = "Hazer";
    }
}