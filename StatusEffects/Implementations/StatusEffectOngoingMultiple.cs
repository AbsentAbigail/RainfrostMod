using System.Collections;
using System.Linq;

namespace RainfrostMod.StatusEffects.Implementations;

internal class StatusEffectOngoingMultiple : StatusEffectOngoing
{
    public StatusEffectOngoing[] effects = [];

    public override void Init()
    {
        foreach (var item in effects)
            item.target = target;

        base.Init();
    }

    public override IEnumerator Add(int add)
    {
        return effects.Select(item => item.Add(add)).GetEnumerator();
    }

    public override IEnumerator Remove(int remove)
    {
        return effects.Select(item => item.Remove(remove)).GetEnumerator();
    }
}