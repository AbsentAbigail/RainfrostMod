using System.Collections.Generic;
using RainfrostMod.Cards.Clunkers;

namespace RainfrostMod.Assets;

public class Clunkers
{
    public static void AddToAssets(List<object> assets)
    {
        assets.AddRange([
            new ScavengerToll().Builder(),
        ]);
    }
}