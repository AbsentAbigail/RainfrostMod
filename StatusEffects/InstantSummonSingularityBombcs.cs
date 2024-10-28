using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;

namespace RainfrostMod.StatusEffects;

internal class InstantSummonSingularityBomb() : AbstractStatus<StatusEffectInstantSummon>(Name)
{
    public const string Name = "Instant Summon Singularity Bomb";

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("Instant Summon Junk In Hand", Name)
            .SubscribeToAfterAllBuildEvent(data =>
            {
                var status = (StatusEffectInstantSummon)data;
                status.targetSummon = AbsentUtils.GetStatusOf<StatusEffectSummon>(SummonSingularityBomb.Name);
            });
    }
}