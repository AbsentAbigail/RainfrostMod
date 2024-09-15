using RainfrostMod.Cards.Items;
using RainfrostMod.StatusEffects.Implementations;
using System.Linq;

namespace RainfrostMod.StatusEffects
{
    internal class InstantSummonRandomPearl() : AbstractStatus<StatusEffectInstantSummonRandomFromPool>(
        Name,
        canStack: true,
        canBoost: true,
        subscribe: data =>
        {
            data.canSummonMultiple = true;
            data.targetSummon = Rainfrost.GetStatus<StatusEffectSummon>(SummonRandomCard.Name);
            data.summonPosition = StatusEffectInstantSummon.Position.Hand;
            data.pool = GetCards(
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

        private static CardData[] GetCards(params string[] cards) => cards.Select(GetCardData).ToArray();

        private static CardData GetCardData(string name) => Rainfrost.TryGet<CardData>(name);
    }
}