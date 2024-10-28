using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class SliverOfStraw() : AbstractCompanion(
    Name, "Sliver of Straw",
    attack: 0, counter: 4,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack("Scrap", 2),
            AbsentUtils.SStack(OnCardPlayedDoubleAllZap.Name)
        ];
        card.attackEffects =
        [
            AbsentUtils.SStack(Zap.Name)
        ];
        card.traits =
        [
            AbsentUtils.TStack(Iterator.Name)
        ];
        card.greetMessages = ["... (They reach a hand out to you. Take it?)"];
    })
{
    public const string Name = "SliverOfStraw";
}