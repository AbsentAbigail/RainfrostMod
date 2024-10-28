using System;
using System.Linq;
using AbsentUtilities;

namespace RainfrostMod.StatusEffects.Implementations;

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

        var anyPreventsDeath = target.statusEffects.Any(s => s.preventDeath);

        if (!(anyPreventsDeath || target.hp.current > 0))
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
        if (!(bool)nextPhase) throw new ArgumentException("Next phase not given!");

        ActionQueue.Stack(new ActionChangePhase(target, TransformInto(), animation)
        {
            priority = 10
        }, true);
    }

    private CardData TransformInto()
    {
        var card = nextPhase.Clone();

        if (!keepUpgrades)
            return card;

        for (var index = 0; index < target.data.upgrades.Count; index++)
        {
            var upgrade = target.data.upgrades[index];
            var upgradeCopy = AbsentUtils.GetCardUpgrade(upgrade.name).Clone();
            if (upgradeCopy.CanAssign(card))
                upgradeCopy.Assign(card);
        }

        return card;
    }
}