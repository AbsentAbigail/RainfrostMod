using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Items;

namespace RainfrostMod.StatusEffects;

internal class WhenHitAddEggbugEggToHand() : AbstractStatus<StatusEffectApplyXWhenHit>(Name)
{
    public const string Name = "When Hit Add Eggbug Egg To Hand";

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("When Hit Add Junk To Hand", Name)
            .WithText("When hit add <{a}> {0} to hand")
            .WithTextInsert(AbstractCard.CardTag(EggbugEgg.Name))
            .SubscribeToAfterAllBuildEvent(data =>
                ((StatusEffectApplyX)data).effectToApply =
                AbsentUtils.GetStatus(InstantSummonEggbugEgg.Name)
            );
    }
}