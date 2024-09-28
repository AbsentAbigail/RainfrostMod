using RainfrostMod.StatusEffects.Implementations;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class WhenScrapLostDamageAlliesInRowAndEnemiesInRow() : AbstractApplyXStatus<StatusEffectApplyXWhenYLostFix>(
        Name, "When scrap is lost, deal <{a}> to allies in the row and enemies in the row",
        canStack: true, canBoost: true,
        applyToFlags: ApplyToFlags.AlliesInRow | ApplyToFlags.EnemiesInRow,
        subscribe: status =>
        {
            status.statusType = "scrap";
            status.targetMustBeAlive = false;

            status.dealDamage = true;
            status.doesDamage = true;
            status.countsAsHit = true;
        })
    {
        public const string Name = "When Scrap Lost Damage AlliesInRow And EnemiesInRow";
    }
}