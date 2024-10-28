using AbsentUtilities;

namespace RainfrostMod.Keywords;

internal class Rot() : AbstractKeyword(Name, "Rot", $"Also hits non-{Tag} allies in row")
{
    public const string Name = "rot";
    public static readonly string Tag = GetTag(Name);
}