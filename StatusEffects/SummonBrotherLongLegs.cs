using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Companion;

namespace RainfrostMod.StatusEffects;

internal class SummonBrotherLongLegs() : AbstractStatus<StatusEffectSummon>(Name)
{
    public const string Name = "Summon Brother Long Legs";
    public static string cardName = BrotherLongLegs.Name;

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("Summon Beepop", Name)
            .WithText("Deploy {0}")
            .WithTextInsert(AbstractCard.CardTag(cardName))
            .SubscribeToAfterAllBuildEvent(data =>
            {
                var status = (StatusEffectSummon)data;
                status.summonCard = AbsentUtils.GetCard(cardName);
                status.gainTrait = null;
                status.setCardType = null;
            });
    }
}