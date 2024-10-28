using System.Reflection;
using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Companion;
using RainfrostMod.StatusEffects.Implementations;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedTransformIntoAttunedSaint() : AbstractStatus<StatusEffectTransformOnCardPlayed>(
    Name, "After triggering 10 times ({a} left), become {0}",
    true,
    subscribe: status =>
    {
        var fg = AbsentUtils.GetStatusOf<StatusEffectNextPhase>("FinalBossPhase2");

        status.animation = fg.animation;
        status.nextPhase = AbsentUtils.GetCard(CardName);
        status.keepUpgrades = true;
        status.textInsert = CardHelper.CardTag(CardName);
    })
{
    public const string Name = "On Card Played Transforrm Into Attuned Saint";
    private const string CardName = AttunedSaint.Name;
}