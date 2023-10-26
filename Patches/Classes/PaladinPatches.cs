using HarmonyLib;
using Orbus.Utils;

namespace Orbus.Patches.Classes
{
    [HarmonyPatch(typeof(MagicalActual.Paladin))]
    internal class PaladinPatches
    {
        [HarmonyPatch(nameof(MagicalActual.Paladin.Start))]
        [HarmonyPostfix]
        public static void Start_Postfix(MagicalActual.Paladin __instance)
        {
            if (__instance.HCFELEODBLD == PlayerUtils.GetPlayerCharacter())
            {
                PlayerUtils.GetActiveClass().SetClass(__instance);
            }
        }
    }
}