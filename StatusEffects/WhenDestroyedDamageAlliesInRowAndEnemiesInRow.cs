using Deadpan.Enums.Engine.Components.Modding;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class WhenDestroyedDamageAlliesInRowAndEnemiesInRow() : AbstractApplyXStatus<StatusEffectApplyXWhenDestroyed>(
        Name,
        canStack: true, canBoost: true,
        applyToFlags: ApplyToFlags.AlliesInRow | ApplyToFlags.EnemiesInRow,
        subscribe: status =>
        {
            status.targetMustBeAlive = false;
            status.dealDamage = true;
            status.countsAsHit = true;
        })
    {
        public const string Name = "When Destroyed Damage AlliesInRow And EnemiesInRow";

        public override StatusEffectDataBuilder Builder()
        {
            return base.Builder()
                .WithDoesDamage(true);
        }
    }
}