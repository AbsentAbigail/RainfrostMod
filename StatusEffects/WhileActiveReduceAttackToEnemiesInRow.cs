using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class WhileActiveReduceAttackToEnemiesInRow() : AbstractApplyXStatus<StatusEffectWhileActiveX>(
        Name, "While active reduce <keyword=attack> of enemies in the row by <{a}>",
        true, true,
        "Ongoing Reduce Attack", ApplyToFlags.EnemiesInRow)
    {
        public const string Name = "While Active Reduce Attack To EnemiesInRow";
    }
}