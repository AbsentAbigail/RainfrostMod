using AbsentUtilities;
using RainfrostMod.Keywords;

namespace RainfrostMod.CardUpgrades;

internal class CardUpgradeIterator() : AbstractCardUpgrade(
    Name, "Tech Charm",
    $"Replace <keyword=health> with 3<keyword=scrap>\nGain {Iterator.Tag}",
    subscribe: charm =>
    {
        charm.effects = [AbsentUtils.SStack("Scrap", 3)];
        charm.giveTraits = [AbsentUtils.TStack(Traits.Iterator.Name)];
        charm.targetConstraints =
        [
            TargetConstraintHelper.General<TargetConstraintHasHealth>("Has Health")
        ];
        charm.setHp = true;
        charm.hpChange = 0;
        charm.scripts = [ScriptableHelper.CreateScriptable<CardScriptRemoveHealthIcon>("Remove Health Icon")];
    })
{
    public const string Name = "CardUpgradeIterator";
}