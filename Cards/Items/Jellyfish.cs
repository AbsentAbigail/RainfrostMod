using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items;

internal class Jellyfish() : AbstractItem(
    Name, "Jellyfish",
    0, true,
    subscribe: card =>
    {
        card.attackEffects = [AbsentUtils.SStack(Zap.Name, 3)];
        card.startWithEffects = [AbsentUtils.SStack(OnCardPlayedIncreaseAttackEffectToSelf.Name)];
    })
{
    public const string Name = "Jellyfish";
}