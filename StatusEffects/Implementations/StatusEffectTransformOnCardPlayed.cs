using System;
using System.Linq;

namespace RainfrostMod.StatusEffects.Implementations
{
    internal class StatusEffectTransformOnCardPlayed : StatusEffectNextPhase
    {
        public bool keepUpgrades;

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
                ActionQueue.Stack(new ActionChangePhase(target, TransformInto(), animation)
                {
                    priority = 10
                }, fixedPosition: true);
                return;
            }
            throw new ArgumentException("Next phase not given!");
        }

        private CardData TransformInto()
        {
            var card = nextPhase.Clone();

            if (!keepUpgrades)
                return card;
            
            foreach (CardUpgradeData upgrade in target.data.upgrades)
            {
                var upgradeCopy = Rainfrost.TryGet<CardUpgradeData>(upgrade.name).Clone();
                if (upgradeCopy.CanAssign(card))
                    upgradeCopy.Assign(card);
            }

            return card;
        }
    }
}