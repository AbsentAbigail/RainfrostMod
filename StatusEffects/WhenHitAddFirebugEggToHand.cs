using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards;
using RainfrostMod.Cards.Items;

namespace RainfrostMod.StatusEffects
{
    internal class WhenHitAddFirebugEggToHand() : AbstractStatus<StatusEffectApplyXOnCardPlayed>(Name)
    {
        public const string Name = "On Card Played Summon Firebug Egg To Hand";

        public override StatusEffectDataBuilder Builder()
        {
            return Rainfrost.StatusCopy("When Hit Add Junk To Hand", Name)
                .WithText("When hit add <{a}> {0} to hand")
                .WithTextInsert(CardHelper.CardTag(FirebugEgg.Name))
                .SubscribeToAfterAllBuildEvent(data =>
                    (data as StatusEffectApplyX).effectToApply = Rainfrost.GetStatus<StatusEffectData>(InstantSummonFirebugEgg.Name)
                );
        }
    }
}