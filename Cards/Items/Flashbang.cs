using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items;

internal class Flashbang() : AbstractItem(
    Name, "Flashbang",
    0, true,
    subscribe: card =>
    {
        card.attackEffects =
        [
            AbsentUtils.SStack(Zap.Name, 3)
        ];

        card.traits =
        [
            AbsentUtils.TStack("Barrage")
        ];
    })
{
    public const string Name = "Flashbang";
}