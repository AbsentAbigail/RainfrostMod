using RainfrostMod.Helpers;
using UnityEngine;

namespace RainfrostMod.Keywords
{
    internal class Zap()
    {
        public static string Name = $"{Rainfrost.Instance.GUID}.zap";

        public static KeywordData Data()
        {
            return StatusIconHelper.CreateIconKeyword(Name, "Zap", "Before attacking, take damage|Does not count down!", "zapicon",
                new Color(1f, 1f, 1f), new Color(0.627f, 0.125f, 0.941f), new Color(0f, 0f, 0f));
        }
    }
}