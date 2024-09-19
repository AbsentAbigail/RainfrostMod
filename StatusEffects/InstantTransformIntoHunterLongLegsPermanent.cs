using RainfrostMod.Cards.Companion;
using RainfrostMod.StatusEffects.Implementations;

namespace RainfrostMod.StatusEffects
{
    internal class InstantTransformIntoHunterLongLegsPermanent() : AbstractStatus<StatusEffectInstantReplaceInDeck>(
        Name,
        subscribe: status =>
        {
            status.replaceWith = Rainfrost.TryGet<CardData>(HunterLongLegs.Name);
        })
    {
        public const string Name = "Instant Transform Into Hunter Long Legs Permanent";
    }
}