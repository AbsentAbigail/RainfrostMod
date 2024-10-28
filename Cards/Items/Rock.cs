using AbsentUtilities;

namespace RainfrostMod.Cards.Items;

internal class Rock() : AbstractItem(
    Name, "Rock",
    1, true,
    subscribe: card =>
    {
        card.attackEffects = [AbsentUtils.SStack("Snow")];
        card.traits = [AbsentUtils.TStack("Noomlin")];
    })
{
    public const string Name = "Rock";
}