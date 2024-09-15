using System;
using System.Collections;

namespace RainfrostMod.StatusEffects.Implementations
{
    internal class StatusEffectOngoingHealth : StatusEffectOngoing
    {
        public override IEnumerator Add(int add)
        {
            target.hp.max += add;
            target.hp.current += add;
            target.PromptUpdate();
            yield break;
        }

        public override IEnumerator Remove(int remove)
        {
            target.hp.max -= remove;
            target.hp.current = Math.Min(target.hp.current, target.hp.max);
            target.PromptUpdate();
            yield break;
        }
    }
}