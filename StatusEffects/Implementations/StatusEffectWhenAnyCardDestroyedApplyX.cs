using System.Collections;

namespace RainfrostMod.StatusEffects.Implementations
{
    internal class StatusEffectWhenAnyCardDestroyedApplyX : StatusEffectApplyXWhenDestroyed
    {
        public override void Init()
        {
            base.OnEntityDestroyed += CheckDestroy;
        }

        public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
        {
            if (entity != target)
            {
                return CheckDeathType(deathType);
            }

            return false;
        }

        public new IEnumerator CheckDestroy(Entity entity, DeathType deathType)
        {
            yield return Run(GetTargets(), GetAmount());
        }
    }
}