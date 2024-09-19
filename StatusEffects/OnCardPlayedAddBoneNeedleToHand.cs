using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards;
using RainfrostMod.Cards.Items;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedAddBoneNeedleToHand() : AbstractStatus<StatusEffectApplyXOnCardPlayed>(Name)
    {
        public const string Name = "On Card Played Summon Bone Needle To Hand";

        public override StatusEffectDataBuilder Builder()
        {
            return Rainfrost.StatusCopy("On Card Played Add Junk To Hand", Name)
                .WithText("Add <{a}> {0} to hand")
                .WithTextInsert(CardHelper.CardTag(BoneNeedle.Name))
                .SubscribeToAfterAllBuildEvent(data =>
                    (data as StatusEffectApplyX).effectToApply = Rainfrost.GetStatus<StatusEffectData>(InstantSummonBoneNeedle.Name)
                );
        }
    }
}