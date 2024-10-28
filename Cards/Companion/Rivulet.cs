using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class Rivulet() : AbstractCompanion(
    Name, "Rivulet",
    3, 1, 3,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(OnOomlinCardPlayedCountDownSelf.Name),
            AbsentUtils.SStack("MultiHit")
        ];

        card.traits = [AbsentUtils.TStack(Slugcat.Name)];

        card.greetMessages = ["WAWAWA!!! (They really want to join you.)"];
    })
{
    public const string Name = "Rivulet";
}