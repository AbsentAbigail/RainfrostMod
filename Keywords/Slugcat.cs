using RainfrostMod.Helpers;

namespace RainfrostMod.Keywords
{
    internal class Slugcat() : AbstractKeyword(Name, "Slugcat", "A card category|Does nothing by itself")
    {
        public const string Name = "slugcat";
        public static string Tag = KeywordHelper.Tag(Name);
    }
}