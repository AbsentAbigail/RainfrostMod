﻿using System.Collections;
using System.Linq;
using UnityEngine;

namespace RainfrostMod.StatusEffects.Implementations;

internal class StatusEffectApplyXPreTurnIgnoreSilence : StatusEffectApplyXPreTurn
{
    public bool cancelTransformBossAttacks = true;

    public override void Init()
    {
        base.Init();
        if (cancelTransformBossAttacks)
            PreAttack += CheckTransformBoss;
    }

    public override bool RunPreAttackEvent(Hit hit)
    {
        if (hit.attacker != target)
            return false;

        if (target.hp.current > 0 || target.FindStatus("Scrap")?.count > 0)
            return false;

        if (target.statusEffects.All(t => t.type != "nextphase"))
            return false;

        return ActionQueue.GetActions().Any(a => a is ActionChangePhase phase && phase.entity == target);
    }

    private IEnumerator CheckTransformBoss(Hit hit)
    {
        hit.countsAsHit = false;
        hit.nullified = true;
        hit.trigger = null;
        yield break;
    }

    public override bool TargetSilenced()
    {
        return false;
    }

    public override bool CanTrigger()
    {
        var result = false;
        if (target.enabled)
            result = !affectedBySnow || (!target.IsSnowed && !target.paused);

        if (!result || !dealDamage)
            return effectToApply;

        return true;
    }

    public override int GetAmount()
    {
        if (!target)
            return 0;

        if (!canBeBoosted)
            return count;

        return Mathf.Max(0, Mathf.RoundToInt((count + target.effectBonus) * target.effectFactor));
    }
}