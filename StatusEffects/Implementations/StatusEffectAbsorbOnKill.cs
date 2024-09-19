using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RainfrostMod.StatusEffects.Implementations
{
    internal class StatusEffectAbsorbOnKill : StatusEffectApplyX
    {
        public bool gainHealth = true;

        public bool gainAttack = true;

        public bool gainEffects = true;

        public TraitData[] illegalTraits;

        public StatusEffectData[] illegalEffects;

        public override void Init()
        {
            base.OnEntityDestroyed += CheckDestroy;
        }

        public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
        {
            if (entity.lastHit != null)
            {
                return entity.lastHit.attacker == target;
            }

            return false;
        }

        public IEnumerator CheckDestroy(Entity entity, DeathType deathType)
        {
            yield return Eat(entity);
            yield break;
        }

        private IEnumerator Eat(Entity entity)
        {
            if (gainHealth)
            {
                GainHealth(entity);
            }

            if (gainAttack)
            {
                GainAttack(entity);
            }

            if (gainEffects)
            {
                yield return GainEffects(entity);
                target.PromptUpdate();
            }
        }

        private void GainHealth(Entity entity)
        {
            target.hp.current += entity.hp.current > 0 ? entity.hp.current : 0;
            target.hp.max += entity.hp.max;
        }

        private void GainAttack(Entity entity)
        {
            target.damage.current += entity.damage.current;
            target.damage.max += entity.damage.max;
        }

        private IEnumerator GainEffects(Entity entity)
        {
            target.attackEffects = [.. CardData.StatusEffectStacks.Stack(target.attackEffects, entity.attackEffects)];
            List<StatusEffectData> list = entity.statusEffects.Where((StatusEffectData e) => e != this && !illegalEffects.Select((StatusEffectData e2) => e2.name).Contains(e.name)).ToList();
            foreach (Entity.TraitStacks trait in entity.traits)
            {
                foreach (StatusEffectData passiveEffect in trait.passiveEffects)
                {
                    list.Remove(passiveEffect);
                }

                int num = trait.count - trait.tempCount;
                if (num > 0 && !illegalTraits.Select((TraitData t) => t.name).Contains(trait.data.name))
                {
                    target.GainTrait(trait.data, num);
                }
            }

            foreach (StatusEffectData item in list)
            {
                yield return StatusEffectSystem.Apply(target, entity, item, item.count);
            }

            yield return target.UpdateTraits();
            target.display.promptUpdateDescription = true;
        }
    }
}