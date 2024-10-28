using AbsentUtilities;

namespace RainfrostMod.Keywords;

internal class Iterator() : AbstractKeyword(Name, "Iterator", "A card category|Does nothing by itself")
{
    public const string Name = "iterator";
    public static readonly string Tag = GetTag(Name);
}