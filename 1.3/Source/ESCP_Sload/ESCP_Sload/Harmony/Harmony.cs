using HarmonyLib;
using RimWorld;
using Verse;
using System;
using System.Linq;
using VFECore;
using System.Reflection;

namespace ESCP_Sload
{
    //Setting the Harmony instance
    [StaticConstructorOnStartup]
    public class Main
    {
        //private static readonly Type patchType = typeof(HarmonyPatches);
        static Main()
        {
            var harmony = new Harmony("com.ESCP_Sload");
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            harmony.Patch(AccessTools.Method(typeof(EquipmentUtility), nameof(EquipmentUtility.CanEquip), new[] { typeof(Thing), typeof(Pawn), typeof(string).MakeByRefType(), typeof(bool) }), postfix: new HarmonyMethod(typeof(EquipmentUtility_SloadCanEquip_Patch), nameof (EquipmentUtility_SloadCanEquip_Patch.SloadWeapon_PostFix)));

            //conditional patches
            /*
            if (LoadedModManager.RunningModsListForReading.Any(x => x.PackageId == "pphhyy.Brachyura"))
            {
                harmony.Patch(AccessTools.Method(AccessTools.TypeByName("CrabMoulting"), "DoMoult"), prefix: new HarmonyMethod(typeof(DubsBadHygienePatches), nameof(NeedIntervalPrefix)));
                harmony.Patch(AccessTools.Method(AccessTools.TypeByName("CrabMoulting"), "CompInspectStringExtra"), prefix: new HarmonyMethod(typeof(DubsBadHygienePatches), nameof(NeedIntervalPrefix)));
            }
            */
        }
    }

    public static class EquipmentUtility_SloadCanEquip_Patch
    {
        public static void SloadWeapon_PostFix(Thing thing, Pawn pawn, ref string cantReason, ref bool __result)
        {
            if (thing is Apparel)
            {
                return;
            }
            if (__result && pawn.def == ThingDefOf.ESCP_SloadRace && ESCP_Sload_ModSettings.SloadCanEquipAllWeapons)
            {
                var thingProps = VFECore.ThingDefExtension.Get(thing.def);
                if (thingProps != null && !thingProps.usableWithShields)
                {
                    __result = false;
                    cantReason = "ESCP_Sload_CantEquipWeapon".Translate();
                }
            }
        }
    }

    [HarmonyPatch(typeof(RestUtility))]
    [HarmonyPatch("GetBedSleepingSlotPosFor")]
    public static class RestUtility_GetBedSleepingSlotPosFor_Patch
    {
        [HarmonyPrefix]
        public static bool GetBedSleepingSlotPosFor_SloadChange(Building_Bed bed, ref IntVec3 __result)
        {
            if(bed.def == ThingDefOf.ESCP_SloadBed)
            {
                __result = new IntVec3(bed.Position.x, bed.Position.y, bed.Position.z);
                return false;
            }
            return true;
        }
    }
}

