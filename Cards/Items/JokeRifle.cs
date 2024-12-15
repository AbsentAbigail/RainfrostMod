using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items;

internal class JokeRifle() : AbstractItem(
    Name, "Joke Rifle",
    1, true,
    Pools.Snowdweller,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(PreCardPlayedKillItemsInHandAndGainFrenzyForEach.Name)
        ];
    })
{
    public const string Name = "JokeRifle";

    public override CardDataBuilder Builder()
    {
        return base.Builder()
            .WithFlavour("RATATATATATATATATAT");
    }
}