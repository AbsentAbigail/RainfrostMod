using System.Collections;

namespace RainfrostMod.StatusEffects.Implementations;

internal class StatusEffectWhenAnyCardDestroyedApplyX : StatusEffectApplyXWhenDestroyed
{
    public override void Init()
    {
        OnEntityDestroyed += CheckDestroy;
    }

    public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
    {
        return entity != target && CheckDeathType(deathType);
    }

    private new IEnumerator CheckDestroy(Entity entity, DeathType deathType)
    {
        yield return Run(GetTargets(), GetAmount());
    }
}