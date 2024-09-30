using RainfrostMod.Helpers;

namespace RainfrostMod.Keywords
{
    internal class Rot() : AbstractKeyword(Name, "Rot", $"Also hits non-{Tag} allies in row")
    {
        public const string Name = "rot";
        public static string Tag = KeywordHelper.Tag(Name);
    }
}