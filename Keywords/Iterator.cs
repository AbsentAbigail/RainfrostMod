using RainfrostMod.Helpers;

namespace RainfrostMod.Keywords
{
    internal class Iterator() : AbstractKeyword(Name, "Iterator", "A card category|Does nothing by itself")
    {
        public const string Name = "iterator";
        public static string Tag = KeywordHelper.Tag(Name);
    }
}