using Deadpan.Enums.Engine.Components.Modding;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class WhenScrapLostDamageAlliesInRowAndEnemiesInRow() : AbstractApplyXStatus<StatusEffectApplyXWhenYLost>(
        Name, "When scrap is lost, deal <{a}> to allies in the row and enemies in the row",
        canStack: true, canBoost: true,
        applyToFlags: ApplyToFlags.AlliesInRow | ApplyToFlags.EnemiesInRow,
        subscribe: status =>
        {
            status.targetMustBeAlive = false;
            status.statusType = "scrap";
            status.dealDamage = true;
            status.countsAsHit = true;
        })
    {
        public const string Name = "When Scrap Lost Damage AlliesInRow And EnemiesInRow";

        public override StatusEffectDataBuilder Builder()
        {
            return base.Builder()
                .WithDoesDamage(true);
        }
    }
}