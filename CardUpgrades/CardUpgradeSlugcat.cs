namespace RainfrostMod.CardUpgrades
{
    internal class CardUpgradeSlugcat() : AbstractCardUpgrade(
        Name, "Scug Charm",
        $"+1 <keyword=attack>\nGain {Keywords.Slugcat.Tag}",
        subscribe: charm =>
        {
            charm.damage = 1;
            charm.giveTraits = [Rainfrost.TStack(Traits.Slugcat.Name)];
        })
    {
        public const string Name = "CardUpgradeSlugcat";
    }
}