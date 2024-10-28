using System.Linq;

namespace RainfrostMod.StatusEffects.Implementations;

internal class StatusEffectApplyXOnCardPlayedWithTrait : StatusEffectApplyXOnCardPlayed
{
    public TraitData[] traits;

    public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
    {
        if (!target.enabled)
            return false;

        if (target == entity)
            return false;

        var traitDatas = entity.traits.Select(t => t.data);
        return traitDatas.ToList().ContainsAny(traits);
    }
}