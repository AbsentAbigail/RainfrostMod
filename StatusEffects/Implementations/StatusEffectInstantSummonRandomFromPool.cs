using RainfrostMod.Helpers;
using System.Collections;

namespace RainfrostMod.StatusEffects.Implementations
{
    internal class StatusEffectInstantSummonRandomFromPool : StatusEffectInstantSummon
    {
        public CardData[] pool;

        public override IEnumerator Process()
        {
            Routine.Clump clump = new();
            int amount = GetAmount();
            for (int i = 0; i < amount; i++)
            {
                if (pool.Length > 0)
                    targetSummon.summonCard = pool.RandomItem();
                LogHelper.Log($"Summon: [{targetSummon.summonCard.name}]");
                clump.Add(TrySummon());
                yield return clump.WaitForEnd();
            }

            yield return Remove();
        }
    }
}