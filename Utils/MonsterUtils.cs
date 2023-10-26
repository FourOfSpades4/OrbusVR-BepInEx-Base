using MagicalActual;
using UnityEngine;
using Il2CppSystem;

namespace Orbus.Utils
{
    /// <summary>
    /// Static utilities class for common functions and properties to be used within your mod code
    /// </summary>
    public static class MonsterUtils
    {
        public static void Highlight(Monster monster, Color color)
        {
            ObjectHighlighter highlighter = monster.BGKMOLDAMCD;
            highlighter.HighlightWithColor(color);
        }

        public static int GetHealth(Monster monster)
        {
            return monster.hitPoints;
        }

        public static int GetMaxHealth(Monster monster)
        {
            return monster.maxHitPoints;
        }
    }
}
