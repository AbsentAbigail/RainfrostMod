using RainfrostMod.Helpers;
using RainfrostMod.Keywords;

namespace RainfrostMod.CardUpgrades
{
    internal class CardUpgradeIterator() : AbstractCardUpgrade(
        Name, "Iterator Charm",
        $"Replace <keyword=health> with 3<keyword=scrap>\nGain {Iterator.Tag}",
        subscribe: charm =>
        {
            charm.effects = [Rainfrost.SStack("Scrap", 3)];
            charm.giveTraits = [Rainfrost.TStack(Traits.Iterator.Name)];
            charm.targetConstraints = [
                TargetConstraintHelper.General<TargetConstraintHasHealth>(),
                TargetConstraintHelper.HasTrait(Traits.Iterator.Name, not: true)
            ];
            charm.setHp = true;
            charm.hpChange = 0;
            charm.scripts = [ScriptableHelper.CreateScriptable<CardScriptRemoveHealthIcon>("Remove Health Icon")];
        })
    {
        public const string Name = "CardUpgradeIterator";
    }
}