using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items;

internal class CherryBomb() : AbstractItem(
    Name, "Cherry Bomb",
    subscribe: card =>
    {
        card.startWithEffects = [AbsentUtils.SStack(OnCardPlayedAddExplodeToAllAllies.Name, 3)];
        card.traits = [AbsentUtils.TStack("Consume")];
    })
{
    public const string Name = "CherryBomb";
}