using RainfrostMod.StatusEffects.Implementations;

namespace RainfrostMod.StatusEffects
{
    internal class OngoingIncreaseHealthAndAttack() : AbstractStatus<StatusEffectOngoingMultiple>(
        Name, canStack: true, subscribe: status =>
        {
            status.effects = [
                Rainfrost.GetStatus<StatusEffectOngoing>("Ongoing Increase Attack"),
                Rainfrost.GetStatus<StatusEffectOngoing>(OngoingIncreaseHealth.Name),
            ];
        })
    {
        public const string Name = "Ongoing Health & Attack";
    }
}