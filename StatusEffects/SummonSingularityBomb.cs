using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards;
using RainfrostMod.Cards.Clunkers;

namespace RainfrostMod.StatusEffects
{
    internal class SummonSingularityBomb() : AbstractStatus<StatusEffectSummon>(Name)
    {
        public const string Name = "Summon Singularity Bomb";
        public static string cardName = SingularityBomb.Name;

        public override StatusEffectDataBuilder Builder()
        {
            return Rainfrost.StatusCopy("Summon Beepop", Name)
                .WithText("Deploy {0}")
                .WithTextInsert(CardHelper.CardTag(cardName))
                .SubscribeToAfterAllBuildEvent(data =>
                {
                    var status = data as StatusEffectSummon;
                    status.summonCard = Rainfrost.TryGet<CardData>(cardName);
                    status.gainTrait = null;
                    status.setCardType = null;
                });
        }
    }
}