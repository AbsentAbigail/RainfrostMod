using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;

namespace RainfrostMod.Helpers
{
    internal static class CardUpgradeHelper
    {
        public static CardUpgradeDataBuilder Charm(string name, string title, string text, Pools pool = Pools.General)
        {
            return new CardUpgradeDataBuilder(Rainfrost.Instance)
                .Create(name)
                .WithType(CardUpgradeData.Type.Charm)
                .SetAddressableSprite(name)
                .WithTitle(title)
                .WithText(text)
                .WithPools(PoolsToStringArray(pool));
        }

        public static CardUpgradeDataBuilder SetAddressableSprite(this CardUpgradeDataBuilder builder, string mainSpriteName) =>
            builder.WithImage(Rainfrost.Cards.GetSprite(mainSpriteName));

        public static string[] PoolsToStringArray(Pools pool)
        {
            string[] pools = [];

            if (pool.HasFlag(Pools.General))
                pools = pools.AddToArray("GeneralCharmPool");

            if (pool.HasFlag(Pools.Snowdweller))
                pools = pools.AddToArray("BasicCharmPool");

            if (pool.HasFlag(Pools.Shademancer))
                pools = pools.AddToArray("MagicCharmPool");

            if (pool.HasFlag(Pools.Clunkmaster))
                pools = pools.AddToArray("ClunkCharmPool");

            return pools;
        }
    }
}