using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class Rivulet() : AbstractUnit(
        Name, "Rivulet",
        3, 1, 3,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(OnOomlinCardPlayedCountDownSelf.Name, 1),
                Rainfrost.SStack("MultiHit", 1),
            ];

            card.traits = [Rainfrost.TStack(Slugcat.Name)];

            card.greetMessages = ["Wawa"];
        })
    {
        public const string Name = "Rivulet";
    }
}