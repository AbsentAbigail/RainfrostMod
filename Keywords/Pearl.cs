using AbsentUtilities;

namespace RainfrostMod.Keywords;

internal class Pearl() : AbstractKeyword(Name, "Pearl", "A card category|Does nothing by itself")
{
    public const string Name = "pearl";
    public static readonly string Tag = GetTag(Name);
}