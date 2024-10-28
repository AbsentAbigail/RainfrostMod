using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Companion;
using RainfrostMod.StatusEffects.Implementations;

namespace RainfrostMod.StatusEffects;

internal class TransformIntoMotherLongLegsOnCardPlayed() : AbstractStatus<StatusEffectTransformOnCardPlayed>(
    Name,
    "Become {0}",
    subscribe: status =>
    {
        var fg = AbsentUtils.GetStatusOf<StatusEffectNextPhase>("FinalBossPhase2");

        status.animation = fg.animation;
        status.nextPhase = AbsentUtils.GetCard(CardName);
        status.textInsert = AbstractCard.CardTag(CardName);
    })
{
    public const string Name = "On Card Played Transform Into Mother Long Legs";
    private const string CardName = MotherLongLegs.Name;
}