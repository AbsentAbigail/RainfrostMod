using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion;

internal class Inspector() : AbstractCompanion(
    Name, "Inspector",
    8, 0, 4,
    subscribe: card =>
    {
        card.attackEffects =
        [
            AbsentUtils.SStack(Zap.Name, 2)
        ];
        card.startWithEffects =
        [
            AbsentUtils.SStack("MultiHit")
        ];
        card.traits =
        [
            AbsentUtils.TStack("Aimless")
        ];

        card.greetMessages = ["01001000 01101001 (You think it wants to join.)"];
    })
{
    public const string Name = "Inspector";
}