using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items
{
    internal class CherryBomb() : AbstractItem(
        Name, "Cherry Bomb",
        null,
        subscribe: card =>
        {
            card.startWithEffects = [Rainfrost.SStack(OnCardPlayedAddExplodeToAllAllies.Name, 3)];
            card.traits = [Rainfrost.TStack("Consume")];
        })
    {
        public const string Name = "CherryBomb";
    }
}