using System.Collections.Generic;
using RainfrostMod.Keywords;

namespace RainfrostMod.Assets;

public class Keywords
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