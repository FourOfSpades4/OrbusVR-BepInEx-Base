using HarmonyLib;
using Orbus.Utils;

namespace Orbus.Patches.Classes
{
    [HarmonyPatch(typeof(MagicalActual.Gambler))]
    internal class ShamanPatches
    {
        [HarmonyPatch(nameof(MagicalActual.Shaman.Start))]
        [HarmonyPostfix]
        public static void Start_Postfix(MagicalActual.Shaman __instance)
        {
            if (__instance.HCFELEODBLD == PlayerUtils.GetPlayerCharacter())
            {
                PlayerUtils.GetActiveClass().SetClass(__instance);
            }
        }
    }
}