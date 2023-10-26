using HarmonyLib;
using Orbus.Utils;

namespace Orbus.Patches.Classes
{
    [HarmonyPatch(typeof(MagicalActual.Gambler))]
    internal class ScoundrelPatches
    {
        [HarmonyPatch(nameof(MagicalActual.Gambler.Start))]
        [HarmonyPostfix]
        public static void Start_Postfix(MagicalActual.Gambler __instance)
        {
            if (__instance.HCFELEODBLD == PlayerUtils.GetPlayerCharacter())
            {
                PlayerUtils.GetActiveClass().SetClass(__instance);
            }
        }
    }
}