using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards;
using RainfrostMod.Cards.Companion;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class WhenDestroyedTransformSelfIntoHunterLongLegs() : AbstractApplyXStatus<StatusEffectApplyXWhenDestroyed>(
        Name, "When destroyed, permanently transform into {0}",
        effectToApply: InstantTransformIntoHunterLongLegsPermanent.Name,
        applyToFlags: ApplyToFlags.Self,
        subscribe: status =>
        {
            status.eventPriority = 99;
            status.targetMustBeAlive = false;
        })
    {
        public const string Name = "When Destroyed Transform Self Into Hunter Long Legs Permanent";

        public override StatusEffectDataBuilder Builder()
        {
            return base.Builder()
                .WithTextInsert(CardHelper.CardTag(HunterLongLegs.Name));
        }
    }
}