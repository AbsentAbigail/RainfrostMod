using RainfrostMod.StatusEffects.Implementations;

namespace RainfrostMod.StatusEffects
{
    internal class OngoingIncreaseHealth() : AbstractStatus<StatusEffectOngoingHealth>(
        Name, canStack: true
        )
    {
        public const string Name = "Ongoing Increase Health";
    }
}