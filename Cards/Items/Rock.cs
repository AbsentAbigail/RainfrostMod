namespace RainfrostMod.Cards.Items
{
    internal class Rock() : AbstractItem(
        Name, "Rock",
        1, true,
        subscribe: card => {
            card.attackEffects = [Rainfrost.SStack("Snow", 1)];
            card.traits = [Rainfrost.TStack("Noomlin")];
        })
    {
        public const string Name = "Rock";
    }
}