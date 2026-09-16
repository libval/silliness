using System;
using BepInEx;
using BepInEx.Logging;
using GorillaLocomotion;
using HarmonyLib;
using silliness.Patches;
using UnityEngine;
using static silliness.Patches.PatchHandler;

namespace silliness
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class HarmonyPatches : BaseUnityPlugin
    {
        private void OnEnable()
        {
            PatchHandler.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            PatchHandler.RemoveHarmonyPatches();
        }
    }
}