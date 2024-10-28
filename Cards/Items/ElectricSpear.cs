using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items;

internal class ElectricSpear() : AbstractItem(
    Name, "Electric Spear",
    3, true,
    subscribe: card =>
    {
        card.attackEffects = [AbsentUtils.SStack(Zap.Name, 4)];
        card.startWithEffects = [AbsentUtils.SStack("On Card Played Reduce Attack Effect 1 To Self")];
    })
{
    public const string Name = "ElectricSpear";
}