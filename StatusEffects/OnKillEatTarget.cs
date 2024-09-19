using RainfrostMod.StatusEffects.Implementations;

namespace RainfrostMod.StatusEffects
{
    internal class OnKillEatTarget() : AbstractApplyXStatus<StatusEffectAbsorbOnKill>(
        Name, "On kill, <keyword=absorb> killed unit",
        subscribe: status =>
        {
            status.illegalTraits = [
                Rainfrost.TryGet<TraitData>("Bombard 1"),
                Rainfrost.TryGet<TraitData>("Bombard 2"),
            ];

            status.illegalEffects = [
                Rainfrost.GetStatus<StatusEffectData>("Bombard 1"),
                Rainfrost.GetStatus<StatusEffectData>("Bombard 2"),
                Rainfrost.GetStatus<StatusEffectData>("On Turn Escape To Self"),
            ];
        })
    {
        public const string Name = "On Kill Eat Target";
    }
}