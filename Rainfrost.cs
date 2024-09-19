using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using RainfrostMod.Cards.Clunkers;
using RainfrostMod.Cards.Companion;
using RainfrostMod.Cards.Items;
using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;
using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using WildfrostHopeMod.Utils;

namespace RainfrostMod
{
    public class Rainfrost : WildfrostMod
    {
        public static Rainfrost Instance;

        public Rainfrost(string directory) : base(directory)
        {
            Instance = this;
        }

        public override string GUID => "absentabigail.wildfrost.rainfrost";

        public override string[] Depends => ["hope.wildfrost.vfx"];

        public override string Title => "Rainfrost [WIP]";

        public override string Description => "Rainworld themed mod. Concepts by Moondial (Work in Progress)";

        private List<object> assets;
        private bool loaded = false;

        [ConfigItem(true, "Replace some wiki sprites with drawn art|Requires restart to work", "Enable alternate art")]
        public bool altArt;

        //this is here to allow our icon to appear in the text box of cards
        public TMP_SpriteAsset assetSprites;

        public override TMP_SpriteAsset SpriteAsset => assetSprites;

        public override void Load()
        {
            if (!loaded) CreateModAssets();
            base.Load();

            //needed for custom icons
            FloatingText ftext = GameObject.FindObjectOfType<FloatingText>(true);
            ftext.textAsset.spriteAsset.fallbackSpriteAssets.Add(assetSprites);
        }

        public override void Unload()
        {
            UnloadFromClasses();
            base.Unload();
        }

        public void CreateModAssets()
        {
            //Needed to get sprites in text boxes
            assetSprites = HopeUtils.CreateSpriteAsset("assetSprites", directoryWithPNGs: ImagePath("Sprites"), textures: [], sprites: []);

            foreach (var character in assetSprites.spriteCharacterTable)
            {
                character.scale = 1.3f;
            }

            Keywords.Zap.Data();

            //make sure you icon is in both the images folder and the sprites subfolder
            StatusIconHelper.CreateIcon("zapicon", ImagePath("zap.png").ToSprite(), "zap", "frost", Color.black, [TryGet<KeywordData>(Keywords.Zap.Name)])
                .GetComponentInChildren<TextMeshProUGUI>(true).enabled = true;

            assets = [
                /**
                 * Status Effects
                 */
                new Zap().Builder(),

                new InstantSummonRandomPearl().Builder(),
                new OnCardPlayedAddRandomPearlToHand().Builder(),
                new SummonRandomCard().Builder(),

                new TemporaryExplode().Builder(),
                new InstantGainExplode().Builder(),

                new SummonBrotherLongLegs().Builder(),
                new TransformIntoDaddyLongLegsOnCardPlayed().Builder(),
                new TransformIntoMotherLongLegsOnCardPlayed().Builder(),
                new OnCardPlayedDamageToNonRotAlliesInRow().Builder(),

                new OnCardPlayedAddNeuronFlyToHand().Builder(),
                new InstantSummonNeuronFly().Builder(),
                new SummonNeuronFly().Builder(),
                new InstantSummonNeuronFlyToDiscardPile().Builder(),
                new OnCardPlayedSummonNeuronFlyToDiscardPile().Builder(),

                new InstantDoubleZap().Builder(),
                new OnCardPlayedDoubleAllZap().Builder(),

                new OngoingIncreaseHealth().Builder(),
                new OngoingIncreaseHealthAndAttack().Builder(),
                new WhileActiveBuffSurvivor().Builder(),
                new WhileActiveGiveSurvivorBuffToAllySlugcats().Builder(),

                new WhileActiveReduceAttackToEnemiesInRow().Builder(),

                /**
                 * Keywords
                 */
                new Keywords.Iterator().Builder(),
                new Keywords.Pearl().Builder(),
                new Keywords.Rot().Builder(),
                new Keywords.Slugcat().Builder(),

                /**
                 * Traits
                 */
                new Traits.Iterator().Builder(),
                new Traits.Pearl().Builder(),
                new Traits.Rot().Builder(),
                new Traits.Slugcat().Builder(),

                /**
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

                /**
                 * Cards (Clunker)
                 */

                /**
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

                /**
                 * Card Upgrades
                 */
            ];

            loaded = true;
        }

        public void UnloadFromClasses()
        {
            List<ClassData> tribes = AddressableLoader.GetGroup<ClassData>("ClassData");
            foreach (ClassData tribe in tribes)
            {
                if (tribe == null || tribe.rewardPools == null)
                    continue;

                foreach (RewardPool pool in tribe.rewardPools)
                {
                    if (pool == null)
                        continue;

                    pool.list.RemoveAllWhere((item) => item == null || item.ModAdded == this);
                }
            }
        }

        public override List<T> AddAssets<T, Y>()
        {
            if (assets.OfType<T>().Any())
                LogHelper.Warn($"[{Title}] adding {typeof(Y).Name}s: {assets.OfType<T>().Select(a => a._data.name).Join()}");
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
                throw new Exception($"TryGet Error: Could not find a [{typeof(T).Name}] with the name [{name}] or [{Deadpan.Enums.Engine.Components.Modding.Extensions.PrefixGUID(name, Instance)}]");

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

        public static CardData.StatusEffectStacks SStack(string name, int amount = 1) => new(TryGet<StatusEffectData>(name), amount);

        public static CardData.TraitStacks TStack(string name, int amount = 1) => new(TryGet<TraitData>(name), amount);

        public static StatusEffectDataBuilder StatusCopy(string oldName, string newName)
        {
            StatusEffectData data = TryGet<StatusEffectData>(oldName).InstantiateKeepName();
            data.name = Instance.GUID + "." + newName;
            StatusEffectDataBuilder builder = data.Edit<StatusEffectData, StatusEffectDataBuilder>();
            builder.Mod = Instance;
            return builder;
        }
    }
}