using Deadpan.Enums.Engine.Components.Modding;
using System;
using static StatusEffectApplyX;

namespace RainfrostMod.Helpers
{
    internal class StatusEffectHelper
    {
        public static StatusEffectDataBuilder DefaultStatusBuilder<T>(
            string name,
            string text = null,
            bool canStack = false,
            bool canBoost = false) where T : StatusEffectData
        {
            var status = new StatusEffectDataBuilder(Rainfrost.Instance)
                .Create<T>(name)
                .WithStackable(canStack)
                .WithCanBeBoosted(canBoost);

            if (text != null)
                status.WithText(text);

            return status;
        }

        public static StatusEffectDataBuilder DefaultApplyXBuilder<T>(
            string name,
            string text = null,
            bool canStack = false,
            bool canBoost = false,
            string effectToApply = "Snow",
            ApplyToFlags applyToFlags = ApplyToFlags.None) where T : StatusEffectApplyX
        {
            return DefaultStatusBuilder<T>(name: name, text: text, canStack: canStack, canBoost: canBoost)
                .SubscribeToAfterAllBuildEvent(data =>
                {
                    var status = data as T;

                    status.effectToApply = Rainfrost.TryGet<StatusEffectData>(effectToApply);
                    status.applyToFlags = applyToFlags;
                });
        }
    }
}