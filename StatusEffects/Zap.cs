using Deadpan.Enums.Engine.Components.Modding;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class Zap() : AbstractApplyXStatus<StatusEffectApplyXPreTurn>(
        Name,
        canStack: true,
        canBoost: true,
        applyToFlags: ApplyToFlags.Self,
        subscribe: data =>
        {
            data.applyFormatKey = Rainfrost.GetStatus<StatusEffectData>("Shroom").applyFormatKey;
            data.dealDamage = true;
            data.countsAsHit = true;
        }
    )
    {
        public const string Name = "Zap";

        public override StatusEffectDataBuilder Builder()
        {
            return base.Builder()
                .WithIconGroupName("health")
                .WithTextInsert("{a}")
                .WithKeyword(Keywords.Zap.Name)
                .WithType("zap")
                .WithVisible(true)
                .WithOffensive(true)
                .WithDoesDamage(true)
                .WithIsStatus(true);
        }
    }
}