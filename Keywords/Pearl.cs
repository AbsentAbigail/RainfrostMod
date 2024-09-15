using RainfrostMod.Helpers;

namespace RainfrostMod.Keywords
{
    internal class Pearl() : AbstractKeyword(Name, "Pearl", "A card category|Does nothing by itself")
    {
        public const string Name = "pearl";
        public static string Tag = KeywordHelper.Tag(Name);
    }
}