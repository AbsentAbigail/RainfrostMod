using System.Collections.Generic;
using RainfrostMod.Cards.Items;

namespace RainfrostMod.Assets;

public class Items
{
    public static void AddToAssets(List<object> assets)
    {
        assets.AddRange([
            new PearlWhite().Builder(),
            new PearlDeepPink().Builder(),
            new PearlLightBlue().Builder(),
            new PearlBrightGreen().Builder(),
            new PearlPaleYellow().Builder(),
            new PearlOrange().Builder(),
            new PearlAquamarine().Builder(),
            new PearlBrightRed().Builder(),
            new PearlBronze().Builder(),
            new PearlBrightPurple().Builder(),
            new PearlDarkMagenta().Builder(),
            new PearlViridian().Builder(),
            new PearlBlack().Builder(),
            new PearlTeal().Builder(),
            new PearlGold().Builder(),
            new PearlDarkGreen().Builder(),
            new PearlDarkBlue().Builder(),
            new PearlBrightBlue().Builder(),

            new NeuronFly().Builder(),
            new SlagResetKey().Builder(),

            new BoneNeedle().Builder(),

            new Spear().Builder(),
            new Rock().Builder(),
            new CherryBomb().Builder(),
            new ElectricSpear().Builder(),
            new RedCentipedeScale().Builder(),
            new Jellyfish().Builder(),

            new EggbugEgg().Builder(),
            new FirebugEgg().Builder(),

            new Mushroom().Builder(),
            new JokeRifle().Builder(),

            new Flashbang().Builder(),
            new Hazer().Builder(),

            new SingularityBomb().Builder(),
        ]);
    }
}