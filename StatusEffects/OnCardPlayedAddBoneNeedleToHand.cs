using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Items;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedAddBoneNeedleToHand() : AbstractStatus<StatusEffectApplyXOnCardPlayed>(Name)
{
    public const string Name = "On Card Played Summon Bone Needle To Hand";

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("On Card Played Add Junk To Hand", Name)
            .WithText("Add <{a}> {0} to hand")
            .WithTextInsert(CardHelper.CardTag(BoneNeedle.Name))
            .SubscribeToAfterAllBuildEvent(data =>
                ((StatusEffectApplyX)data).effectToApply =
                AbsentUtils.GetStatus(InstantSummonBoneNeedle.Name)
            );
    }
}