using HarmonyLib;
using MagicalActual;
using System.Linq;
using Orbus.Utils;
using UnityEngine;
using Il2CppSystem;
using System.Collections.Generic;
using Il2CppSystem.Collections;
using Il2CppMono;
using BepInEx.Unity.IL2CPP.Utils;

namespace OrbusBase.Utils
{
    public static class ScoundrelUtils
    {

        public enum Card
        {
            NO_CARD = 0,
            POISON = 1,
            ICE = 2,
            FLAME = 3,
            LIGHT = 4,
            ASH = 5,
            FLINT = 6
        }

        public static void UseCard(Gambler gambler, Card card) 
        {
            gambler.DLSDFADFDS(1, (byte)card, true);
        }

        public static void BurnCard(Gambler gambler, Card card)
        {
            gambler.DLSDFADFDS(2, (byte)card, true);
        }

        public static void ShootMonster(Gambler gambler, Monster monster, int bullets = 1, bool doMaxRank = false)
        {
            gambler.DSLDPFAADD(monster._JANFCAJMFMP_k__BackingField, monster.gameObject.transform.position, doMaxRank ? 10 : 0, bullets, false);
        }
    }
}
