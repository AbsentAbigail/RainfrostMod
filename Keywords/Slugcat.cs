using AbsentUtilities;

namespace RainfrostMod.Keywords;

internal class Slugcat() : AbstractKeyword(Name, "Slugcat", "When a card is <consumed>, heal 1<keyword=health>")
{
    public const string Name = "slugcat";
    public static readonly string Tag = GetTag(Name);
}