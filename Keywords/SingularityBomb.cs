﻿using AbsentUtilities;

namespace RainfrostMod.Keywords;

internal class SingularityBomb()
    : AbstractKeyword(Name, "Singularity Bomb", "Hits all ally and enemy targets in the row")
{
    public const string Name = "singularitybomb";
    public static readonly string Tag = GetTag(Name);
}