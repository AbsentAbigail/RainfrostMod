using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion;

internal class Overseer() : AbstractCompanion(
    Name, "Overseer",
    1, 0, 2,
    subscribe: card =>
    {
        card.attackEffects = [AbsentUtils.SStack(Zap.Name)];
        card.startWithEffects = [AbsentUtils.SStack(WhileActiveGainMultiHitForEachActiveIterators.Name)];
        card.traits = [AbsentUtils.TStack("Fragile")];
        card.greetMessages = ["[ (+ +)/ ] (It projects a friendly picture. Let it join?)"];
    })
{
    public const string Name = "Overseer";
}