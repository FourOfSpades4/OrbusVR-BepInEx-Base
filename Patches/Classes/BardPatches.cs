using HarmonyLib;
using Orbus.Utils;

namespace Orbus.Patches.Classes
{
    [HarmonyPatch(typeof(MagicalActual.Bard))]
    internal class BardPatches
    {
        [HarmonyPatch(nameof(MagicalActual.Bard.Start))]
        [HarmonyPostfix]
        public static void Start_Postfix(MagicalActual.Bard __instance)
        {
            if (__instance.HCFELEODBLD == PlayerUtils.GetPlayerCharacter())
            {
                PlayerUtils.GetActiveClass().SetClass(__instance);
            }
        }
    }
}