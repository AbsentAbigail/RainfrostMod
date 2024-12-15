using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using JetBrains.Annotations;
using RainfrostMod.Assets;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.U2D;
using WildfrostHopeMod.Utils;
using WildfrostHopeMod.VFX;

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
    }

    public override string GUID => "absentabigail.wildfrost.rainfrost";

    public override string[] Depends =>
        ["hope.wildfrost.vfx", "absentabigail.wildfrost.absentutils", "mhcdc9.wildfrost.battle"];

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

        Battles.AddBattles();

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

        VFXHelper.DamageVFX = new GIFLoader(this, ImagePath("DamageAnimations"));
        VFXHelper.DamageVFX.RegisterAllAsDamageEffect();

        Keywords.Zap.Data();

        StatusIconHelper.CreateIcon(
                "zap",
                _cards?.GetSprite("zap") ?? ImagePath("zap.png").ToSprite(),
                "zap", -1, "ink", Color.black,
                [AbsentUtils.GetKeyword(Keywords.Zap.Name)])
            .GetComponentInChildren<TextMeshProUGUI>(true).enabled = true;

        _assets = [];

        Status.AddToAssets(_assets);
        Companions.AddToAssets(_assets);
        Clunkers.AddToAssets(_assets);
        Items.AddToAssets(_assets);
        Enemies.AddToAssets(_assets);
        Assets.Traits.AddToAssets(_assets);
        Assets.Keywords.AddToAssets(_assets);
        Assets.CardUpgrades.AddToAssets(_assets);

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
}