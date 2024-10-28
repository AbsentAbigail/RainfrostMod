using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class SevenRedSuns() : AbstractCompanion(
    Name, "Seven Red Suns",
    attack: 0, counter: 7,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack("Scrap", 2),
            AbsentUtils.SStack(OnCardPlayedCountDownIteratorAllies.Name, 7)
        ];

        card.traits =
        [
            AbsentUtils.TStack(Iterator.Name),
            AbsentUtils.TStack("Spark")
        ];
        card.greetMessages = ["Greetings, could I perchance join your crew?"];
    })
{
    public const string Name = "SevenRedSuns";
}