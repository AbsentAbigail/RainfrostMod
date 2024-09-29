using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using System;

namespace RainfrostMod.CardUpgrades
{
    internal abstract class AbstractCardUpgrade(
        string name, string title, string text, Pools pools = Pools.General,
        Action<CardUpgradeData> subscribe = null
        )
    {
        public virtual CardUpgradeDataBuilder Builder()
        {
            subscribe ??= delegate { };
            return CardUpgradeHelper.Charm(name, title, text, pools)
                .SubscribeToAfterAllBuildEvent(subscribe.Invoke);
        }
    }
}