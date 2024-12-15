using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using WildfrostHopeMod.VFX;

namespace RainfrostMod.StatusEffects.Implementations;

internal class StatusEffectZap : StatusEffectData
{
    public bool cancelTransformBossAttacks = true;

    public override void Init()
    {
        PreCardPlayed += CheckPreCardPlay;
        if (cancelTransformBossAttacks)
            PreAttack += CheckTransformBoss;
    }

    public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets)
    {
        if (!target.enabled)
            return false;
        return entity == target;
    }

    private IEnumerator CheckPreCardPlay(Entity entity, Entity[] targets)
    {
        if (!target || !target.alive)
            yield break;

        VFXHelper.DamageVFX.TryPlayEffect("zap", target.transform.position, target.transform.lossyScale,
            GIFLoader.PlayType.damageEffect);
        yield return new WaitForSeconds(.4f);
        yield return new Hit(applier, target, count)
        {
            canRetaliate = false,
            countsAsHit = true
        }.Process();
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

    private static IEnumerator CheckTransformBoss(Hit hit)
    {
        hit.countsAsHit = false;
        hit.nullified = true;
        hit.trigger = null;
        yield break;
    }

    public override bool CanTrigger()
    {
        var result = false;
        if (target.enabled)
            result = !affectedBySnow || (!target.IsSnowed && !target.paused);

        return result;
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