using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class Slugpup() : AbstractUnit(
        Name, "Slugpups",
        2, 1, 3,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(WhileActiveAddMultiHitToAlliedSlugcats.Name, 1),
            ];

            card.traits = [
                Rainfrost.TStack(Slugcat.Name),
            ];

            card.greetMessages = ["...Wawa! (It seems they wish to join you.)"];
        },
        altSprite: true)
    {
        public const string Name = "Slugpup";
    }
}