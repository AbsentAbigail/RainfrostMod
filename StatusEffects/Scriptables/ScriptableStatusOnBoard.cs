using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

namespace RainfrostMod.StatusEffects.Scriptables;

internal class ScriptableStatusOnBoard : ScriptableAmount
{
    public string statusType;
    public bool allies;
    public bool enemies;
    public float multiplier = 1;
    public bool count;

    public override int Get(Entity entity)
    {
        var result = 0;

        if (allies)
            result += entity.GetAllies().Sum(Count);

        if (enemies)
            result += entity.GetAllEnemies().Sum(Count);

        return Mathf.FloorToInt(result * multiplier);
    }

    private int Count(Entity entity)
    {
        var status = entity.statusEffects.FirstOrDefault(s => s.type.Equals(statusType));
        if (status == null)
            return 0;
        return count ? status.count : 1;
    }
}