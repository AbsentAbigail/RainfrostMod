using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards;
using RainfrostMod.Cards.Companion;

namespace RainfrostMod.StatusEffects
{
    internal class SummonBrotherLongLegs() : AbstractStatus<StatusEffectSummon>(Name)
    {
        public const string Name = "Summon Brother Long Legs";
        public static string cardName = BrotherLongLegs.Name;
        public override StatusEffectDataBuilder Builder()
        {
            return Rainfrost.StatusCopy("Summon Beepop", Name)
                .WithText("Deploy {0}")
                .WithTextInsert(CardHelper.CardTag(cardName))
                .SubscribeToAfterAllBuildEvent(data => {
                    var status = data as StatusEffectSummon;
                    status.summonCard = Rainfrost.TryGet<CardData>(cardName);
                    status.gainTrait = null;
                    status.setCardType = null;
                });
        }
    }
}