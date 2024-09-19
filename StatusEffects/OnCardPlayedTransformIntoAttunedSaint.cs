using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards;
using RainfrostMod.Cards.Companion;
using RainfrostMod.StatusEffects.Implementations;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedTransformIntoAttunedSaint() : AbstractStatus<StatusEffectTransformOnCardPlayed>(
        Name, "After triggering 10 times ({a} left), become {0}",
        true,
        subscribe: status =>
        {
            var fg = Rainfrost.GetStatus<StatusEffectNextPhase>("FinalBossPhase2");

            status.animation = fg.animation;
            status.nextPhase = Rainfrost.TryGet<CardData>(cardName);
        })
    {
        public const string Name = "On Card Played Transforrm Into Attuned Saint";
        public static string cardName = AttunedSaint.Name;

        public override StatusEffectDataBuilder Builder()
        {
            return base.Builder()
                .WithTextInsert(CardHelper.CardTag(cardName));
        }
    }
}