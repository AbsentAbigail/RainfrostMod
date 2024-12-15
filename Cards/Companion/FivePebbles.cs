using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class FivePebbles() : AbstractCompanion(
    Name, "Five Pebbles",
    attack: 0, counter: 5,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack("Scrap", 3),
            AbsentUtils.SStack(SummonBrotherLongLegs.Name),
            AbsentUtils.SStack("On Card Played Lose Scrap To Self")
        ];
        card.traits =
        [
            AbsentUtils.TStack(Iterator.Name),
            AbsentUtils.TStack("Spark")
        ];
        card.greetMessages = ["Fine, since you rescued me I suppose I'll help you."];
    },
    altSprite: true
)
{
    public const string Name = "FivePebbles";
    
    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .WithFlavour("Who knew the cure for cancer was durians?");
    }
}