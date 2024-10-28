using AbsentUtilities;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedIncreaseAttackOfAlliesInRow() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
    Name, "Increase <keyword=attack> of allies in the row by <{a}>",
    true, true,
    "Increase Attack", ApplyToFlags.AlliesInRow)
{
    public const string Name = "On Card Played Increase Attack To AlliesInRow";
}