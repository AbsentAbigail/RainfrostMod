using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class Slugpup() : AbstractCompanion(
    Name, "Slugpups",
    2, 1, 3,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(WhileActiveAddMultiHitToAlliedSlugcats.Name)
        ];

        card.traits =
        [
            AbsentUtils.TStack(Slugcat.Name)
        ];

        card.greetMessages = ["...Wawa! (It seems they wish to join you.)"];
    },
    altSprite: true)
{
    public const string Name = "Slugpup";
}