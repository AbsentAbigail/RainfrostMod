using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;

namespace RainfrostMod.StatusEffects;

internal class InstantSummonEggbugEgg() : AbstractStatus<StatusEffectInstantSummon>(Name)
{
    public const string Name = "Instant Summon Eggbug Egg";

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("Instant Summon Junk In Hand", Name)
            .SubscribeToAfterAllBuildEvent(data =>
            {
                var status = data as StatusEffectInstantSummon;
                status.targetSummon = AbsentUtils.GetStatusOf<StatusEffectSummon>(SummonEggbugEgg.Name);
            });
    }
}