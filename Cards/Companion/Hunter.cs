﻿using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion
{
    internal class Hunter() : AbstractUnit(
        Name, "Hunter",
        6, 4, 3,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(WhenDestroyedTransformSelfIntoHunterLongLegs.Name),
                Rainfrost.SStack("MultiHit", 1)
            ];

            card.traits = [
                Rainfrost.TStack(Traits.Slugcat.Name),
            ];
        })
    {
        public const string Name = "Hunter";
    }
}