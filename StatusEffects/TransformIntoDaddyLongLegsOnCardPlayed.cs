using System.Reflection;
using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Companion;
using RainfrostMod.StatusEffects.Implementations;

namespace RainfrostMod.StatusEffects;

internal class TransformIntoDaddyLongLegsOnCardPlayed() : AbstractStatus<StatusEffectTransformOnCardPlayed>(
    Name,
    "Become {0}",
    subscribe: status =>
    {
        var fg = AbsentUtils.GetStatusOf<StatusEffectNextPhase>("FinalBossPhase2");

        status.animation = fg.animation;
        status.nextPhase = AbsentUtils.GetCard(CardName);
        status.textInsert = CardHelper.CardTag(CardName);
    })
{
    public const string Name = "On Card Played Transform Into Daddy Long Legs";
    private const string CardName = DaddyLongLegs.Name;
}