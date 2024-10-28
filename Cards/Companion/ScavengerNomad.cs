﻿using AbsentUtilities;

namespace RainfrostMod.Cards.Companion;

internal class ScavengerNomad() : AbstractCompanion(
    Name, "Scavenger Nomad",
    7, 4, 4,
    subscribe: card =>
    {
        card.traits =
        [
            AbsentUtils.TStack("Draw", 2)
        ];
    })
{
    public const string Name = "ScavengerNomad";
}