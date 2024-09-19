using System;
using System.Linq;

namespace RainfrostMod.StatusEffects.Implementations
{
    internal class StatusEffectTransformOnCardPlayed : StatusEffectNextPhase
    {
        public override void Init()
        {
        }

        public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
        {
            if (entity != target)
                return false;

            if (activated)
                return false;

            bool preventDeath = target.statusEffects.Any(s => s.preventDeath);

            if (!(preventDeath || target.hp.current > 0))
                return false;

            count--;
            target.display.promptUpdateDescription = true;
            target.PromptUpdate();

            if (count > 0)
                return false;

            Transform();
            return true;
        }

        private void Transform()
        {
            activated = true;
            if ((bool)nextPhase)
            {
                ActionQueue.Stack(new ActionChangePhase(target, nextPhase.Clone(), animation)
                {
                    priority = 10
                }, fixedPosition: true);
                return;
            }
            throw new ArgumentException("Next phase not given!");
        }
    }
}