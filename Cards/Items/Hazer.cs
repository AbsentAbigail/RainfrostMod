using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items;

internal class Hazer() : AbstractItem(
    Name, "Hazer",
    0, true,
    subscribe: card =>
    {
        card.attackEffects =
        [
            AbsentUtils.SStack("Haze")
        ];

        card.startWithEffects =
        [
            AbsentUtils.SStack(OnCardPlayedApplyNullToRandomAlly.Name, 4)
        ];
    })
{
    public const string Name = "Hazer";
}