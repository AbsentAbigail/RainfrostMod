using AbsentUtilities;

namespace RainfrostMod.Cards.Items;

internal class Spear() : AbstractItem(
    Name, "Spear",
    5, true,
    subscribe: card => card.traits = [AbsentUtils.TStack("Zoomlin")])
{
    public const string Name = "Spear";
}