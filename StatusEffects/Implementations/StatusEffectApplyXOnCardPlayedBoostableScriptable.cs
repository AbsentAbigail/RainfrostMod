namespace RainfrostMod.StatusEffects.Implementations
{
    internal class StatusEffectApplyXOnCardPlayedBoostableScriptable : StatusEffectApplyXOnCardPlayed
    {
        public override int GetAmount(Entity entity, bool equalAmount = false, int equalTo = 0)
        {
            int i = scriptableAmount ? GetAmount() : 1;
            return base.GetAmount(entity, equalAmount, equalTo) * i;
        }
    }
}