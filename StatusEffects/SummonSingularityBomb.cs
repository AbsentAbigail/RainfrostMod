using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Clunkers;
using RainfrostMod.Cards.Items;

namespace RainfrostMod.StatusEffects;

internal class SummonSingularityBomb() : AbstractStatus<StatusEffectSummon>(Name)
{
    public const string Name = "Summon Singularity Bomb";
    private const string CardName = SingularityBomb.Name;

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("Summon Junk", Name)
            .SubscribeToAfterAllBuildEvent(data =>
            {
                var status = (StatusEffectSummon)data;
                status.summonCard = AbsentUtils.GetCard(CardName);
                status.gainTrait = null;
                status.setCardType = null;
            });
    }
}