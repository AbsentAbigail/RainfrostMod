using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedReduceAttackOfEnemiesInRow() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
        Name, "Reduce <keyword=attack> of enemies in the row by <{a}>",
        true, true,
        "Reduce Attack", ApplyToFlags.EnemiesInRow)
    {
        public const string Name = "On Card Played Reduce Attack To EnemiesInRow";
    }
}