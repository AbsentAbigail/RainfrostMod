﻿using Deadpan.Enums.Engine.Components.Modding;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedIncreaseAttackEffectToSelf() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
        Name, "Increase by {a} when played",
        true, false,
        effectToApply: "Increase Attack Effects",
        applyToFlags: ApplyToFlags.Self
        )
    {
        public const string Name = "On card Played Increase Attack Effect To Self";
    }
}