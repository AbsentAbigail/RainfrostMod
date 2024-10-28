using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using JetBrains.Annotations;
using RainfrostMod.Cards.Clunkers;
using RainfrostMod.Cards.Companion;
using RainfrostMod.Cards.Items;
using RainfrostMod.CardUpgrades;
using RainfrostMod.Keywords;
using RainfrostMod.StatusEffects;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.U2D;
using WildfrostHopeMod.Utils;
using Logger = HarmonyLib.Tools.Logger;
using SingularityBomb = RainfrostMod.Cards.Items.SingularityBomb;
using Zap = RainfrostMod.Keywords.Zap;

namespace RainfrostMod;

[UsedImplicitly]
public class Rainfrost : WildfrostMod
{
    private static SpriteAtlas _cards;
    private static string _modDirectory;
    private List<object> _assets;
    private bool _loaded;

    [UsedImplicitly]
    [ConfigItem(true, "Replace some wiki sprites with drawn art (Requires restart to work)", "Enable alternate art")]
    public bool AltArt;

    //this is here to allow our icon to appear in the text box of cards
    public TMP_SpriteAsset AssetSprites;

    public Rainfrost(string directory) : base(directory)
    {
        _modDirectory = ModDirectory;

        HarmonyInstance.PatchAll(typeof(PatchHarmony));
    }

    public override string GUID => "absentabigail.wildfrost.rainfrost";

    public override string[] Depends => ["hope.wildfrost.vfx", "absentabigail.wildfrost.absentutils"];

    public override string Title => "Rainfrost";

    public override string Description => GetDescription();

    public override TMP_SpriteAsset SpriteAsset => AssetSprites;

    public static string CatalogFolder => Path.Combine(_modDirectory, "Windows");
    public static string CatalogPath => Path.Combine(CatalogFolder, "catalog.json");

    public override void Load()
    {
        AbsentUtils.AddModInfo(new AbsentUtils.ModInfo
        {
            Mod = this,
            Prefix = "Rainfrost",
            HasAltArt = AltArt
        });

        if (!_loaded) CreateModAssets();
        base.Load();

        //needed for custom icons
        var floatingText = Object.FindObjectOfType<FloatingText>(true);
        floatingText.textAsset.spriteAsset.fallbackSpriteAssets.Add(AssetSprites);
    }

    public override void Unload()
    {
        UnloadFromClasses();
        base.Unload();
    }

    private void CreateModAssets()
    {
        if (!Addressables.ResourceLocators.Any(r => r is ResourceLocationMap map && map.LocatorId == CatalogPath))
            Addressables.LoadContentCatalogAsync(CatalogPath).WaitForCompletion();

        _cards = (SpriteAtlas)Addressables.LoadAssetAsync<Object>($"Assets/{GUID}/Cards.spriteatlas")
            .WaitForCompletion();
        AbsentUtils.GetModInfo(Assembly.GetExecutingAssembly()).SetSprites(_cards);

        var modInfo = AbsentUtils.GetModInfo(Assembly.GetExecutingAssembly());
        Debug.Log("Bundle sprite count: " + modInfo.Sprites?.spriteCount);

        AssetSprites = HopeUtils.CreateSpriteAsset("RainfrostAssets", ImagePath(""));

        Zap.Data();

        StatusIconHelper.CreateIcon(
                "zap",
                _cards?.GetSprite("zap") ?? ImagePath("zap.png").ToSprite(),
                "zap", -1, "ink", Color.black,
                [AbsentUtils.GetKeyword(Zap.Name)])
            .GetComponentInChildren<TextMeshProUGUI>(true).enabled = true;

        _assets =
        [
            /*
             * Status Effects
             */
            new StatusEffects.Zap().Builder(),

            new InstantSummonRandomPearl().Builder(),
            new OnCardPlayedAddRandomPearlToHand().Builder(),
            new SummonRandomCard().Builder(),

            new TemporaryExplode().Builder(),
            new InstantGainExplode().Builder(),

            new SummonBrotherLongLegs().Builder(),
            new TransformIntoDaddyLongLegsOnCardPlayed().Builder(),
            new TransformIntoMotherLongLegsOnCardPlayed().Builder(),

            new OnCardPlayedAddNeuronFlyToHand().Builder(),
            new InstantSummonNeuronFly().Builder(),
            new SummonNeuronFly().Builder(),
            new InstantSummonNeuronFlyToDiscardPile().Builder(),
            new OnCardPlayedSummonNeuronFlyToDiscardPile().Builder(),

            new InstantDoubleZap().Builder(),
            new OnCardPlayedDoubleAllZap().Builder(),

            new OnCardPlayedIncreaseHealthAndAttackForEachAlliedSlugcat().Builder(),

            new OnCardPlayedIncreaseAttackOfAlliesInRow().Builder(),
            new OnCardPlayedReduceAttackOfEnemiesInRow().Builder(),

            new InstantTransformIntoHunterLongLegsPermanent().Builder(),
            new WhenDestroyedTransformSelfIntoHunterLongLegs().Builder(),

            new OnCardPlayedAddBoneNeedleToHand().Builder(),
            new InstantSummonBoneNeedle().Builder(),
            new SummonBoneNeedle().Builder(),
            new OnCardPlayedIncreaseHealthToRandomAlly().Builder(),

            new OnCardPlayedApplySpiceToCardsInHand().Builder(),

            new OnCardPlayedSummonCopyOfLeftmostCardInHand().Builder(),

            new OnOomlinCardPlayedCountDownSelf().Builder(),

            new OnCardPlayedTransformIntoAttunedSaint().Builder(),

            new SummonSingularityBomb().Builder(),
            new InstantSummonSingularityBomb().Builder(),
            new OnCardPlayedAddSingularityBombToHand().Builder(),

            new WhileActiveAddMultiHitToAlliedSlugcats().Builder(),

            new WhileActiveAddMultiHitToAllPearls().Builder(),

            new OnPearlCardPlayedDraw().Builder(),

            new OnCardPlayedCountDownIteratorAllies().Builder(),

            new OnCardPlayedAddExplodeToAllAllies().Builder(),
            new OnCardPlayedIncreaseAttackEffectToSelf().Builder(),

            new WhileActiveGainMultiHitForEachActiveIterators().Builder(),

            new WhenHitAddEggbugEggToHand().Builder(),
            new InstantSummonEggbugEgg().Builder(),
            new SummonEggbugEgg().Builder(),
            new WhenHitAddFirebugEggToHand().Builder(),
            new InstantSummonFirebugEgg().Builder(),
            new SummonFirebugEgg().Builder(),

            new InstantApplyFrenzyToApplier().Builder(),
            new InstantKillAndApplyMultiHitToApplier().Builder(),
            new PreCardPlayedKillItemsInHandAndGainFrenzyForEach().Builder(),

            new OnCardPlayedApplyNullToRandomAlly().Builder(),

            new OnKillGainAttackAndHealth().Builder(),
            new OnCardPlayedTriggerAgainstNonRotAlliesInRow().Builder(),

            new WhenCardConsumedApplyHealToSelf().Builder(),

            new Kill().Builder(),

            new TargetModeFullRow().Builder(),

            /*
             * Keywords
             */
            new Iterator().Builder(),
            new Pearl().Builder(),
            new Rot().Builder(),
            new Slugcat().Builder(),

            new Nuke().Builder(),

            /*
             * Traits
             */
            new Traits.Iterator().Builder(),
            new Traits.Pearl().Builder(),
            new Traits.Rot().Builder(),
            new Traits.Slugcat().Builder(),

            new Traits.Nuke().Builder(),

            /*
             * Cards (Companions)
             */
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

            /*
             * Cards (Clunker)
             */

            new ScavengerToll().Builder(),

            /*
             * Cards (Items)
             */
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

            /*
             * Card Upgrades
             */
            new CardUpgradeRot().Builder(),
            new CardUpgradeIterator().Builder(),
            new CardUpgradeSlugcat().Builder(),
            new CardUpgradeZap().Builder(),
            new CardUpgradeBattery().Builder()
        ];

        _loaded = true;
    }

    public void UnloadFromClasses()
    {
        var tribes = AddressableLoader.GetGroup<ClassData>("ClassData");
        foreach (var pool in from tribe in tribes
                 where tribe != null && tribe.rewardPools != null
                 from pool in tribe.rewardPools
                 where pool != null
                 select pool)
            pool.list.RemoveAllWhere(item => item == null || item.ModAdded == this);
    }

    public override List<T> AddAssets<T, TY>()
    {
        if (_assets.OfType<T>().Any())
            LogHelper.Log($"Adding {typeof(TY).Name}s: {_assets.OfType<T>().Select(a => a._data.name).Join()}");
        return _assets.OfType<T>().ToList();
    }

    private static string GetDescription()
    {
        return MakeDescription(
            "Rainworld themed mod",
            "Made by Moondial, Sudux, KDeveloper, Code_Null, Lamb, AbsentAbigail",
            "",
            "Current Content:",
            "21 Companions",
            "1 Clunker",
            "24+ Items",
            "5 Charms",
            "1 Status Effect",
            "+ More to come",
            "",
            "Source code: https://github.com/AbsentAbigail/RainfrostMod"
        );
    }

    private static string MakeDescription(params string[] lines)
    {
        return lines.Join(delimiter: "\n");
    }
    
    [HarmonyPatch(typeof(DebugLoggerTextWriter), "WriteLine")]
    private class PatchHarmony
    {
        [UsedImplicitly]
        private static bool Prefix()
        {
            Postfix();
            return false;
        }

        private static void Postfix()
        {
            Logger.ChannelFilter = (Logger.LogChannel)(8 + 16);
        }
    }
}