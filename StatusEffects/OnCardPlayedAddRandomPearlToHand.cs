using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Keywords;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedAddRandomPearlToHand() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(Name)
    {
        public const string Name = "On Card Played Add Random Pearl To Hand";
        public override StatusEffectDataBuilder Builder()
        {
            return Rainfrost.StatusCopy("On Card Played Add Junk To Hand", name)
                .WithText($"Add <{{a}}> random {Pearl.Tag} Card(s) to hand")
                .SubscribeToAfterAllBuildEvent(data => 
                    (data as StatusEffectApplyX).effectToApply = Rainfrost.GetStatus<StatusEffectData>(InstantSummonRandomPearl.Name)
                );
        }
    }
}