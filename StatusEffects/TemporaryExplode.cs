namespace RainfrostMod.StatusEffects
{
    internal class TemporaryExplode() : AbstractStatus<StatusEffectTemporaryTrait>(
        Name,
        subscribe: data => data.trait = Rainfrost.TryGet<TraitData>("Explode")
    )
    {
        public const string Name = "Temporary Explode";
    }
}