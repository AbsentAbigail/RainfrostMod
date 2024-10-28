using System.Collections;

namespace RainfrostMod.StatusEffects.Implementations;

internal class StatusEffectApplyXWhenYLostFix : StatusEffectApplyXWhenYLost
{
    public new void OnDestroy()
    {
        Events.OnEntityDisplayUpdated -= EntityDisplayUpdated;
    }

    public override void Init()
    {
        Events.OnEntityDisplayUpdated += EntityDisplayUpdated;
    }

    public new void EntityDisplayUpdated(Entity entity)
    {
        var statusAmount = GetCurrentAmount();
        if (!(active && statusAmount != currentAmount && entity == target))
            return;

        var difference = statusAmount - currentAmount;
        currentAmount = statusAmount;
        if (!(difference < 0 && (!whenAllLost || currentAmount == 0) && target.enabled && !target.silenced &&
              (!targetMustBeAlive || (target.alive && Battle.IsOnBoard(target)))))
            return;

        ActionQueue.Insert(0, new ActionSequence(Lost(-difference))
        {
            note = name,
            priority = eventPriority
        }, true);
    }

    public new IEnumerator Lost(int amount)
    {
        if ((bool)this && (!targetMustBeAlive || target.alive))
            yield return Run(GetTargets(null, GetTargetContainers(), GetTargetActualContainers()), amount);
    }
}