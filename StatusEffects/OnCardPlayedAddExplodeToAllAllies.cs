using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedAddExplodeToAllAllies() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
        Name, "Add Explode <{a}> to all allies",
        true, true,
        InstantGainExplode.Name,
        ApplyToFlags.Allies)
    {
        public const string Name = "On Card Played Add Explode To All Allies";
    }
}