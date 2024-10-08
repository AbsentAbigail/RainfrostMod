﻿using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class Survivor() : AbstractUnit(
        Name, "Survivor",
        4, 3, 3,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(OnCardPlayedIncreaseHealthAndAttackForEachAlliedSlugcat.Name, 1)
            ];

            card.traits = [
                Rainfrost.TStack(Slugcat.Name)
            ];

            card.greetMessages = ["Wawa? (It seems they are asking to join.)"];
        },
        altSprite: true)
    {
        public const string Name = "Survivor";
    }
}