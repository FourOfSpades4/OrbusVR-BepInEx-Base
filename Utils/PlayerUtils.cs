using MagicalActual;
using UnityEngine;
using Il2CppSystem;

namespace Orbus.Utils
{
    /// <summary>
    /// Static utilities class for common functions and properties to be used within your mod code
    /// </summary>
    public static class PlayerUtils
    {
        public static PlayerActiveClass playerActiveClass = new PlayerActiveClass();

        public static int PlayerHealth
        {
            get => GetPlayerCharacter().myMonster.hitPoints;
        }
        public static int PlayerMaxHealth
        {
            get => GetPlayerCharacter().myMonster.maxHitPoints;
        }


        public static float PlayerStamina
        {
            get => GetPlayerCharacter().INDJNOHADBE;
        }

        public static float PlayerMaxStamina
        {
            get => GetPlayerCharacter().maxStamina;
        }


        public static PlayerActiveClass GetActiveClass()
        {
            return playerActiveClass;
        }

        public static PlayerCharacter GetPlayerCharacter()
        {
            return PlayerCharacter.MMECOAJKONB;
        }

        public static void Loot(Loot loot)
        {
            GetPlayerCharacter().DoLoot(loot.IJJGNKLFGJN.JGFIJDCMHDB);
        }

        public static void Loot(BossChest loot)
        {
            GetPlayerCharacter().DoLoot(loot.IJJGNKLFGJN.JGFIJDCMHDB);
        }

        public static void Respawn()
        {
            PlayerCharacter.MMECOAJKONB.GraveyardResurrect();
        }

        public static void Teleport(Vector3 location)
        {
            Nullable<Quaternion> quaterion = new Nullable<Quaternion>() { value = new Quaternion(), has_value = true };
            GetPlayerCharacter().teleportPlayer(location, quaterion, true, false);
        }
    }

    public class PlayerActiveClass
    {
        public enum PlayerClass
        {
            None, Ghost, Paladin, Warrior, Musketeer, Bard, Runemage, Gambler, Ranger, Shaman
        }

        public Paladin paladin { get; private set; }
        public Swordboard warrior { get; private set; }
        public Orbhealer musketeer { get; private set; }
        public Bard bard { get; private set; }
        public Runemage runemage { get; private set; }
        public Gambler gambler { get; private set; }
        public Archer ranger { get; private set; }
        public Shaman shaman { get; private set; }

        internal PlayerActiveClass()
        {
        }

        public PlayerClass GetActiveClass()
        {
            PlayerAvatar playerAvatar = PlayerUtils.GetPlayerCharacter().myPlayerAvatar;
            if (playerAvatar == null)
                return PlayerClass.None;
            MagicalActual.PlayerClass playerClass = playerAvatar.currentActiveClass;
            if (playerClass == null)
                return PlayerClass.None;
            switch (PlayerUtils.GetPlayerCharacter().myPlayerAvatar.currentActiveClass.className)
            {
                case "Paladin": return PlayerClass.Paladin;
                case "Swordboard": return PlayerClass.Warrior;
                case "Orbhealer": return PlayerClass.Musketeer;
                case "Bard": return PlayerClass.Bard;
                case "Runemage": return PlayerClass.Runemage;
                case "Gambler": return PlayerClass.Gambler;
                case "Archer": return PlayerClass.Ranger;
                case "Shaman": return PlayerClass.Shaman;
                case "Ghost": return PlayerClass.Ghost;
                default: return PlayerClass.None;
            }
        }

        public void SetClass<T>(T playerClass)
        {
            switch (playerClass)
            {
                case Paladin c: paladin = c; break;
                case Swordboard c: warrior = c; break;
                case Orbhealer c: musketeer = c; break;
                case Bard c: bard = c; break;
                case Runemage c: runemage = c; break;
                case Gambler c: gambler = c; break;
                case Archer c: ranger = c; break;
                case Shaman c: shaman = c; break;
            }
        }
    }
}
