using System.Linq;
using AbsentUtilities;
using RainfrostMod.Cards.Items;
using RainfrostMod.StatusEffects.Implementations;

namespace RainfrostMod.StatusEffects;

internal class InstantSummonRandomPearl() : AbstractStatus<StatusEffectInstantSummonRandomFromPool>(
    Name,
    canStack: true,
    canBoost: true,
    subscribe: status =>
    {
        status.canSummonMultiple = true;
        status.targetSummon = AbsentUtils.GetStatusOf<StatusEffectSummon>(SummonRandomCard.Name);
        status.summonPosition = StatusEffectInstantSummon.Position.Hand;
        status.pool = GetCards(
            PearlWhite.Name,
            PearlDeepPink.Name,
            PearlLightBlue.Name,
            PearlBrightGreen.Name,
            PearlPaleYellow.Name,
            PearlOrange.Name,
            PearlAquamarine.Name,
            PearlBrightRed.Name,
            PearlBronze.Name,
            PearlBrightPurple.Name,
            PearlDarkMagenta.Name,
            PearlViridian.Name,
            PearlBlack.Name,
            PearlTeal.Name,
            PearlGold.Name,
            PearlDarkGreen.Name,
            PearlDarkBlue.Name,
            PearlBrightBlue.Name
        );
    })
{
    public const string Name = "Instant Summon Random Pearl";

    private static CardData[] GetCards(params string[] cards)
    {
        return cards.Select(GetCardData).ToArray();
    }

    private static CardData GetCardData(string name)
    {
        return AbsentUtils.GetCard(name);
    }
}