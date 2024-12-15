using System.Collections.Generic;
using RainfrostMod.Cards.Companion;

namespace RainfrostMod.Assets;

public class Companions
{
    public static void AddToAssets(List<object> assets)
    {
        assets.AddRange([
            new LooksToTheMoon().Builder(),

            new FivePebbles().Builder(),
            new BrotherLongLegs().Builder(),
            new DaddyLongLegs().Builder(),
            new MotherLongLegs().Builder(),

            new NoSignificantHarassment().Builder(),

            new SliverOfStraw().Builder(),

            new Survivor().Builder(),

            new Monk().Builder(),

            new Hunter().Builder(),
            new HunterLongLegs().Builder(),

            new Spearmaster().Builder(),

            new Artificer().Builder(),

            new Gourmand().Builder(),

            new Rivulet().Builder(),

            new Saint().Builder(),
            new AttunedSaint().Builder(),

            new Enot().Builder(),

            new Slugpup().Builder(),

            new ScavengerNomad().Builder(),

            new ScavengerMerchant().Builder(),

            new SevenRedSuns().Builder(),

            new Overseer().Builder(),

            new Inspector().Builder(),

            new Eggbug().Builder(),
            new Firebug().Builder(),
        ]);
    }
}