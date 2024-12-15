using System.Collections.Generic;
using RainfrostMod.Cards.Enemies;

namespace RainfrostMod.Assets;

public static class Enemies
{
    public static void AddToAssets(List<object> assets)
    {
        assets.AddRange([
            new RedCentipede().Builder(),
            new RedCentipede2().Builder(),
            new InfantCentipede().Builder(),
            new AdultCentipede().Builder(),
            new Centiwing().Builder(),
            new Aquapede().Builder(),

            new RedLizard().Builder(),
            new BlueLizard().Builder(),
            new GreenLizard().Builder(),
            new PinkLizard().Builder(),
            new WhiteLizard().Builder(),
        ]);
    }
}