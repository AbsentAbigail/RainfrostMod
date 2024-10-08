﻿using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class Enot() : AbstractUnit(
        Name, "Enot",
        4, 1, 5,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(SummonSingularityBomb.Name),
            ];

            card.traits = [
                Rainfrost.TStack("Spark"),
                Rainfrost.TStack(Slugcat.Name),
            ];

            card.greetMessages = ["Hey bby, can I ask u on a date?"];
        })
    {
        public const string Name = "Enot";
    }
}