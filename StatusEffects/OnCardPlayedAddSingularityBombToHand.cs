using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Items;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedAddSingularityBombToHand() : AbstractStatus<StatusEffectApplyXOnCardPlayed>(Name)
{
    public const string Name = "On Card Played Summon Singularity Bomb To Hand";

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("On Card Played Add Junk To Hand", Name)
            .WithText("Add <{a}> {0} to hand")
            .WithTextInsert(AbstractCard.CardTag(SingularityBomb.Name))
            .SubscribeToAfterAllBuildEvent(data =>
                ((StatusEffectApplyX)data).effectToApply = AbsentUtils.GetStatus(InstantSummonSingularityBomb.Name)
            );
    }
}