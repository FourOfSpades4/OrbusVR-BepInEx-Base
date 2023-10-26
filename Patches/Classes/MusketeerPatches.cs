using HarmonyLib;
using Orbus.Utils;

namespace Orbus.Patches.Classes
{
    [HarmonyPatch(typeof(MagicalActual.Orbhealer))]
    internal class MusketeerPatches
    {
        [HarmonyPatch(nameof(MagicalActual.Orbhealer.Start))]
        [HarmonyPostfix]
        public static void Start_Postfix(MagicalActual.Orbhealer __instance)
        {
            if (__instance.HCFELEODBLD == PlayerUtils.GetPlayerCharacter())
            {
                PlayerUtils.GetActiveClass().SetClass(__instance);
            }
        }
    }
}