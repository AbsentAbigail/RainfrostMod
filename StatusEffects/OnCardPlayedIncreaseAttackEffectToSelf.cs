using AbsentUtilities;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedIncreaseAttackEffectToSelf() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
    Name, "Increase by {a} when played",
    true, false,
    "Increase Attack Effects"
)
{
    public const string Name = "On card Played Increase Attack Effect To Self";
}