using RainfrostMod.Helpers;

namespace RainfrostMod.Keywords
{
    internal class SingularityBomb() : AbstractKeyword(Name, "Singularity Bomb", $"Hits all ally and enemy targets in the row")
    {
        public const string Name = "singularitybomb";
        public static string Tag = KeywordHelper.Tag(Name);
    }
}