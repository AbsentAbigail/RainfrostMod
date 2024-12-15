using System.Collections.Generic;
using RainfrostMod.CardUpgrades;

namespace RainfrostMod.Assets;

public class CardUpgrades
{
    public static void AddToAssets(List<object> assets)
    {
        assets.AddRange([
            new CardUpgradeRot().Builder(),
            new CardUpgradeIterator().Builder(),
            new CardUpgradeSlugcat().Builder(),
            new CardUpgradeZap().Builder(),
            new CardUpgradeBattery().Builder()
        ]);
    }
}