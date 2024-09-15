using System;
using System.Collections;

namespace RainfrostMod.StatusEffects.Implementations
{
    internal class StatusEffectOngoingMultiple : StatusEffectOngoing
    {
        public StatusEffectOngoing[] effects;

        public override void Init()
        {
            foreach (var item in effects)
                item.target = target;

            base.Init();
        }

        public override IEnumerator Add(int add)
        {
            foreach (var item in effects)
                yield return item.Add(add);
            yield break;
        }

        public override IEnumerator Remove(int remove)
        {
            foreach (var item in effects)
                yield return item.Remove(remove);
            yield break;
        }
    }
}