using AbsentUtilities;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedApplyNullToRandomAlly() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
    Name,
    "Apply <{a}> <keyword=null> to a random ally",
    true, true,
    "Null",
    ApplyToFlags.RandomAlly
)
{
    public const string Name = "On Card Played Apply Null To Random Ally";
}