using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;

namespace RainfrostMod.Keywords;

internal class Nuke() : AbstractKeyword(Name, $"<color=#{_color.ToHexRGB()}>Nuke</color>", "Hits all ally and enemy targets in the row!")
{
    public const string Name = "nuke";
    public static readonly string Tag = GetTag(Name);

    private static Color _color = Color(0, 255, 244);
    public override KeywordDataBuilder Builder()
    {
        return base.Builder().WithTitleColour(_color);
    }
}