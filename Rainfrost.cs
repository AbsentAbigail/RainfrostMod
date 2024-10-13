using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using RainfrostMod.Cards.Clunkers;
using RainfrostMod.Cards.Companion;
using RainfrostMod.Cards.Items;
using RainfrostMod.CardUpgrades;
using RainfrostMod.Helpers;
using RainfrostMod.Keywords;
using RainfrostMod.StatusEffects;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.U2D;
using WildfrostHopeMod.Utils;
using Extensions = Deadpan.Enums.Engine.Components.Modding.Extensions;
using Logger = HarmonyLib.Tools.Logger;
using LogHelper = RainfrostMod.Helpers.LogHelper;
using Object = UnityEngine.Object;
using SingularityBomb = RainfrostMod.Keywords.SingularityBomb;
using Zap = RainfrostMod.Keywords.Zap;

namespace RainfrostMod;

public class Rainfrost : WildfrostMod
{
    public static Rainfrost Instance;

    public static SpriteAtlas Cards;

    [ConfigItem(true, "Replace some wiki sprites with drawn art (Requires restart to work)", "Enable alternate art")]
    public bool altArt;

    private List<object> assets;

    //this is here to allow our icon to appear in the text box of cards
    public TMP_SpriteAsset assetSprites;
    private bool loaded;

    public Rainfrost(string directory) : base(directory)
    {
        AbsentUtils.Mod = this;
        AbsentUtils.Prefix = "Rainfrost";
        Instance = this;
        HarmonyInstance.PatchAll(typeof(PatchHarmony));
    }

    public override string GUID => "absentabigail.wildfrost.rainfrost";

    public override string[] Depends => ["hope.wildfrost.vfx"];

    public override string Title => "Rainfrost";

    public override string Description =>
        "Rainworld themed mod\nMade by Moondial, Sudux, KDeveloper, Code_Null, Lamb, AbsentAbigail";

    public override TMP_SpriteAsset SpriteAsset => assetSprites;

    public static string CatalogFolder => Path.Combine(Instance.ModDirectory, "Windows");
    public static string CatalogPath => Path.Combine(CatalogFolder, "catalog.json");

    public override void Load()
    {
        if (!loaded) CreateModAssets();
        base.Load();

        //needed for custom icons
        var ftext = GameObject.FindObjectOfType<FloatingText>(true);
        ftext.textAsset.spriteAsset.fallbackSpriteAssets.Add(assetSprites);
    }

    public override void Unload()
    {
        UnloadFromClasses();
        base.Unload();
    }

    public void CreateModAssets()
    {
        if (!Addressables.ResourceLocators.Any(r => r is ResourceLocationMap map && map.LocatorId == CatalogPath))
            Addressables.LoadContentCatalogAsync(CatalogPath).WaitForCompletion();

        Cards = (SpriteAtlas)Addressables.LoadAssetAsync<Object>($"Assets/{GUID}/Cards.spriteatlas")
            .WaitForCompletion();
        if (Cards == null)
            throw new Exception("Sprite Assets not found");
        AbsentUtils.Sprites = Cards;

        //Needed to get sprites in text boxes
        assetSprites =
            HopeUtils.CreateSpriteAsset("assetSprites", ImagePath("Sprites"), [], [ImagePath("zap.png").ToSprite()]);

        Zap.Data();

        //make sure you icon is in both the images folder and the sprites subfolder
        StatusIconHelper.CreateIcon("zap", Cards.GetSprite("zap"), "zap", "ink", Color.black,
                [TryGet<KeywordData>(Zap.Name)])
            .GetComponentInChildren<TextMeshProUGUI>(true).enabled = true;

        assets =
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
            new WhenScrapLostDamageAlliesInRowAndEnemiesInRow().Builder(),

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

            new SingularityBomb().Builder(),

            /*
             * Traits
             */
            new Traits.Iterator().Builder(),
            new Traits.Pearl().Builder(),
            new Traits.Rot().Builder(),
            new Traits.Slugcat().Builder(),

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

            new Centipede().Builder(),
            new Overseer().Builder(),

            new Inspector().Builder(),

            new Eggbug().Builder(),
            new Firebug().Builder(),

            /*
             * Cards (Clunker)
             */
            new Cards.Clunkers.SingularityBomb().Builder(),

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

            /*
             * Card Upgrades
             */
            new CardUpgradeRot().Builder(),
            new CardUpgradeIterator().Builder(),
            new CardUpgradeSlugcat().Builder(),
            new CardUpgradeZap().Builder(),
            new CardUpgradeBattery().Builder()
        ];

        loaded = true;
    }

    public void UnloadFromClasses()
    {
        var tribes = AddressableLoader.GetGroup<ClassData>("ClassData");
        foreach (var tribe in tribes)
        {
            if (tribe == null || tribe.rewardPools == null)
                continue;

            foreach (var pool in tribe.rewardPools)
            {
                if (pool == null)
                    continue;

                pool.list.RemoveAllWhere(item => item == null || item.ModAdded == this);
            }
        }
    }

    public override List<T> AddAssets<T, Y>()
    {
        if (assets.OfType<T>().Any())
            LogHelper.Log($"Adding {typeof(Y).Name}s: {assets.OfType<T>().Select(a => a._data.name).Join()}");
        return assets.OfType<T>().ToList();
    }

    public static T TryGet<T>(string name) where T : DataFile
    {
        T data;
        if (typeof(StatusEffectData).IsAssignableFrom(typeof(T)))
            data = Instance.Get<StatusEffectData>(name) as T;
        else
            data = Instance.Get<T>(name);

        if (data == null)
            throw new Exception(
                $"TryGet Error: Could not find a [{typeof(T).Name}] with the name [{name}] or [{Extensions.PrefixGUID(name, Instance)}]");

        return data;
    }

    public static T TryGetOrNull<T>(string name) where T : DataFile
    {
        T data;
        if (typeof(StatusEffectData).IsAssignableFrom(typeof(T)))
            data = Instance.Get<StatusEffectData>(name) as T;
        else
            data = Instance.Get<T>(name);

        return data;
    }

    public static T GetStatus<T>(string name) where T : StatusEffectData
    {
        return Instance.GetStatusEffect<T>(name);
    }

    public static CardData.StatusEffectStacks SStack(string name, int amount = 1)
    {
        return new CardData.StatusEffectStacks(TryGet<StatusEffectData>(name), amount);
    }

    public static CardData.TraitStacks TStack(string name, int amount = 1)
    {
        return new CardData.TraitStacks(TryGet<TraitData>(name), amount);
    }

    public static StatusEffectDataBuilder StatusCopy(string oldName, string newName)
    {
        var data = TryGet<StatusEffectData>(oldName).InstantiateKeepName();
        data.name = Instance.GUID + "." + newName;
        var builder = data.Edit<StatusEffectData, StatusEffectDataBuilder>();
        builder.Mod = Instance;
        return builder;
    }

    [HarmonyPatch(typeof(DebugLoggerTextWriter), "WriteLine")]
    private class PatchHarmony
    {
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