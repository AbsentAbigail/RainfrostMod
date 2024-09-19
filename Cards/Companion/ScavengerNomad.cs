namespace RainfrostMod.Cards.Companion
{
    internal class ScavengerNomad() : AbstractUnit(
        Name, "Scavenger Nomad",
        7, 4, 4,
        subscribe: card =>
        {
            card.traits = [
                Rainfrost.TStack("Draw", 2),
            ];
        })
    {
        public const string Name = "ScavengerNomad";
    }
}