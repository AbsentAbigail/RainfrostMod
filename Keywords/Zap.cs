using System.Reflection;
using AbsentUtilities;
using UnityEngine;
using static AbsentUtilities.StatusIconHelper;

namespace RainfrostMod.Keywords;

internal class Zap
{
    public static string Name = $"{AbsentUtils.GetModInfo(Assembly.GetExecutingAssembly()).Mod.GUID}.zap";
    private static readonly Color Color = AbstractKeyword.Color(253, 195, 97);

    public static KeywordData Data()
    {
        return CreateIconKeyword(Name, "Zap", "Before attacking, take damage|Does not count down!",
            "zap",
            Color, new Color(1f, 1f, 1f), Color,
            new Color(0f, 0f, 0f));
    }
}