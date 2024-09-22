using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items
{
    internal class JokeRifle() : AbstractItem(
        Name, "Joke Rifle",
        1, true,
        Pools.Snowdweller,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(PreCardPlayedKillItemsInHandAndGainFrenzyForEach.Name, 1),
            ];
        })
    {
        public const string Name = "JokeRifle";
    }
}