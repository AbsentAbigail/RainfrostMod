using RainfrostMod.StatusEffects.Implementations;

namespace RainfrostMod.StatusEffects
{
    internal class Kill() : AbstractStatus<StatusEffectInstantKill>(
        Name, "Kill",
        true
        )
    {
        public const string Name = "Kill";
    }
}