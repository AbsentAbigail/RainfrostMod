using RainfrostMod.Helpers;
using System.Collections;
using UnityEngine;

namespace RainfrostMod.StatusEffects.Implementations
{
    internal class StatusEffectApplyXWhenYLostFix : StatusEffectApplyXWhenYLost
    {
        public override void Init()
        {
            Events.OnEntityDisplayUpdated += EntityDisplayUpdated;
        }

        public new void OnDestroy()
        {
            Events.OnEntityDisplayUpdated -= EntityDisplayUpdated;
        }

        public new void EntityDisplayUpdated(Entity entity)
        {
            int statusAmount = GetCurrentAmount();
            if (!(active && statusAmount != currentAmount && entity == target))
                return;
            
            int difference = statusAmount - currentAmount;
            currentAmount = statusAmount;
            if (!(difference < 0 && (!whenAllLost || currentAmount == 0) && target.enabled && !target.silenced && (!targetMustBeAlive || (target.alive && Battle.IsOnBoard(target)))))
                return;

            ActionQueue.Insert(0, new ActionSequence(Lost(-difference))
            {
                note = base.name,
                priority = eventPriority
            }, fixedPosition: true);
        }

        public new IEnumerator Lost(int amount)
        {
            if ((bool)this && (!targetMustBeAlive || target.alive))
            {
                yield return Run(GetTargets(null, GetTargetContainers(), GetTargetActualContainers()), amount);
            }
        }
    }
}