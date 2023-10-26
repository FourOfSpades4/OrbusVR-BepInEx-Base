using HarmonyLib;
using Orbus.Utils;

namespace Orbus.Patches.Classes
{
    [HarmonyPatch(typeof(MagicalActual.Runemage))]
    internal class RunemagePatches
    {
        [HarmonyPatch(nameof(MagicalActual.Runemage.Start))]
        [HarmonyPostfix]
        public static void Start_Postfix(MagicalActual.Runemage __instance)
        {
            if (__instance.HCFELEODBLD == PlayerUtils.GetPlayerCharacter())
            {
                PlayerUtils.GetActiveClass().SetClass(__instance);
            }
        }
    }
}