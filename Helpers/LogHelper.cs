﻿using UnityEngine;

namespace RainfrostMod.Helpers
{
    internal class LogHelper
    {
        private const string Prefix = "Rainfrost";

        public static void Log(string message)
        {
            Debug.Log($"[{Prefix}] {message}");
        }

        public static void Warn(string message)
        {
            Debug.LogWarning($"[{Prefix} Warning] {message}");
        }

        public static void Error(string message)
        {
            Debug.LogError($"[{Prefix} Error] {message}");
        }
    }
}