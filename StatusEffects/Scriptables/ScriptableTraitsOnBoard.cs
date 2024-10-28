using System.Linq;
using UnityEngine;

namespace RainfrostMod.StatusEffects.Scriptables;

internal class ScriptableTraitsOnBoard : ScriptableAmount
{
    public TraitData trait;
    public bool allies;
    public bool enemies;
    public float multiplier = 1;

    public override int Get(Entity entity)
    {
        var result = 0;

        if (allies)
            result += entity.GetAllies().Count(a => a.traits.Any(t => t.data == trait));

        if (enemies)
            result += entity.GetAllEnemies().Count(a => a.traits.Any(t => t.data == trait));

        return Mathf.FloorToInt(result * multiplier);
    }
}