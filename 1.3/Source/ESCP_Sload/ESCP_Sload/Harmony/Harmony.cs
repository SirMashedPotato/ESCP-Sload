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
            if (__result && pawn.def == ThingDefOf.ESCP_SloadRace && ModSettingsUtility.ESCP_RaceTools_SloadCanEquipAllWeapons())
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
    /*
    [HarmonyPatch(typeof(CompRottable))]
    [HarmonyPatch("StageChanged")]
    public static class CompRottable_StageChanged_Patch
    {
        [HarmonyPostfix]
        public static void CompRottable_SloadChange(ref CompRottable __instance)
        {
            Corpse corpse = __instance.parent as Corpse;
            if (corpse.InnerPawn. def.defName == "ESCP_SloadRace")
            {
                if (__instance.Stage == RotStage.Dessicated)
                {
                    FilthMaker.TryMakeFilth(corpse.Position, corpse.Map, RimWorld.ThingDefOf.Filth_CorpseBile, 10);
                    GenExplosion.DoExplosion(corpse.Position, corpse.Map, 2, DamageDefOf.Extinguish, corpse, -1, -1f, null, null, null, null, corpse.InnerPawn.def.race.BloodDef, 1f, 3, false, null, 0f, 1, 0f, false, null, null);
                    //corpse.Destroy();
                }
            }
        }
    }
    */
}

