using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedDoubleAllZap() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
        Name, "Double <ALL> {0}",
        effectToApply: InstantDoubleZap.Name,
        applyToFlags: ApplyToFlags.Allies | ApplyToFlags.Self | ApplyToFlags.Enemies | ApplyToFlags.Hand
        )
    {
        public const string Name = "On Card Played Double All Zap";

        public override StatusEffectDataBuilder Builder()
        {
            return base.Builder()
                .WithTextInsert($"<keyword={Keywords.Zap.Name}>");
        }
    }
}