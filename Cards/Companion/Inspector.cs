namespace RainfrostMod.Cards.Companion
{
    internal class Inspector() : AbstractUnit(
        Name, "Inspector",
        8, 0, 4,
        subscribe: card =>
        {
            card.attackEffects = [
                Rainfrost.SStack(StatusEffects.Zap.Name, 2),
            ];
            card.startWithEffects = [
                Rainfrost.SStack("MultiHit", 1),
            ];
            card.traits = [
                Rainfrost.TStack("Aimless"),
            ];

            card.greetMessages = ["01001000 01101001 (You think it wants to join.)"];
        })
    {
        public const string Name = "Inspector";
    }
}