using HarmonyLib;
using Orbus.Utils;

namespace Orbus.Patches.Classes
{
    [HarmonyPatch(typeof(MagicalActual.Archer))]
    internal class RangerPatches
    {
        [HarmonyPatch(nameof(MagicalActual.Archer.Start))]
        [HarmonyPostfix]
        public static void Start_Postfix(MagicalActual.Archer __instance)
        {
            if (__instance.HCFELEODBLD == PlayerUtils.GetPlayerCharacter())
            {
                PlayerUtils.GetActiveClass().SetClass(__instance);
            }
        }
    }
}