using RainfrostMod.Helpers;

namespace RainfrostMod.Keywords
{
    internal class Rot() : AbstractKeyword(Name, "Rot", "A card category|Does nothing by itself")
    {
        public const string Name = "rot";
        public static string Tag = KeywordHelper.Tag(Name);
    }
}