using HarmonyLib;
using Orbus.Utils;

namespace Orbus.Patches.Classes
{
    [HarmonyPatch(typeof(MagicalActual.Swordboard))]
    internal class WarriorPatches
    {
        [HarmonyPatch(nameof(MagicalActual.Swordboard.Start))]
        [HarmonyPostfix]
        public static void Start_Postfix(MagicalActual.Swordboard __instance)
        {
            if (__instance.HCFELEODBLD == PlayerUtils.GetPlayerCharacter())
            {
                PlayerUtils.GetActiveClass().SetClass(__instance);
            }
        }
    }
}