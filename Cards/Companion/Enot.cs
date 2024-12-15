using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class Enot() : AbstractCompanion(
    Name, "Enot",
    4, 1, 5,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(OnCardPlayedAddSingularityBombToHand.Name)
        ];
        card.traits =
        [
            AbsentUtils.TStack(Slugcat.Name)
        ];

        card.greetMessages = ["Hey bby, can I ask u on a date?"];
    })
{
    public const string Name = "Enot";
    
    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .WithFlavour("Thanks, Andrew");
    }
}