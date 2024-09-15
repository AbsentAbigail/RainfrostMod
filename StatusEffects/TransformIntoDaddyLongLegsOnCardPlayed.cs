using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards;
using RainfrostMod.Cards.Companion;
using RainfrostMod.StatusEffects.Implementations;

namespace RainfrostMod.StatusEffects
{
    internal class TransformIntoDaddyLongLegsOnCardPlayed() : AbstractStatus<StatusEffectTransformOnCardPlayed>(Name, "Become {0}", subscribe: data =>
    {
        var fg = Rainfrost.GetStatus<StatusEffectNextPhase>("FinalBossPhase2");

        data.animation = fg.animation;
        data.nextPhase = Rainfrost.TryGet<CardData>(cardName);
    })
    {
        public const string Name = "On Card Played Transform Into Daddy Long Legs";
        public static string cardName = DaddyLongLegs.Name;

        public override StatusEffectDataBuilder Builder()
        {
            return base.Builder()
                .WithTextInsert(CardHelper.CardTag(cardName));
        }
    }
}