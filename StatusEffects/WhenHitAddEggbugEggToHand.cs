using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards;
using RainfrostMod.Cards.Items;

namespace RainfrostMod.StatusEffects
{
    internal class WhenHitAddEggbugEggToHand() : AbstractStatus<StatusEffectApplyXWhenHit>(Name)
    {
        public const string Name = "When Hit Add Eggbug Egg To Hand";

        public override StatusEffectDataBuilder Builder()
        {
            return Rainfrost.StatusCopy("When Hit Add Junk To Hand", Name)
                .WithText("When hit add <{a}> {0} to hand")
                .WithTextInsert(CardHelper.CardTag(EggbugEgg.Name))
                .SubscribeToAfterAllBuildEvent(data =>
                    (data as StatusEffectApplyX).effectToApply = Rainfrost.GetStatus<StatusEffectData>(InstantSummonEggbugEgg.Name)
                );
        }
    }
}