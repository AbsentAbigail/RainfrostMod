using System.Collections.Generic;
using RainfrostMod.Traits;

namespace RainfrostMod.Assets;

public class Traits
{
    public static void AddToAssets(List<object> assets)
    {
        assets.AddRange([
            new Iterator().Builder(),
            new Pearl().Builder(),
            new Rot().Builder(),
            new Slugcat().Builder(),

            new Nuke().Builder(),
        ]);
    }
}