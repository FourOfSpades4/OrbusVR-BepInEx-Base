using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using UnityEngine;

namespace Orbus
{
    // TODO Review this file and update to your own requirements.

    [BepInPlugin(MyGUID, PluginName, VersionString)]
    public class OrbusBasePlugin : BasePlugin
    {
        private const string MyGUID = "com.spades.orbus";
        private const string PluginName = "OrbusBase";
        private const string VersionString = "1.0.0";

        private static readonly Harmony Harmony = new Harmony(MyGUID);
        public static ManualLogSource Logger = new ManualLogSource(PluginName);

        public override void Load()
        {
            Log.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loading...");
            Harmony.PatchAll();

            Logger = Log;
        }
    }
}
