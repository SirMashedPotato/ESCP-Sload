using HarmonyLib;
using RimWorld;
using Verse;

namespace ESCP_Sload
{

    [HarmonyPatch(typeof(CompMilkable))]
    class CompMilkable_Active_Patch
    {
        [HarmonyPrefix]
        [HarmonyPatch("Active", MethodType.Getter)]
        public static bool CompMilkable_Active_SloadThrallFix(ref CompMilkable __instance, ref bool __result)
        {
            if (ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallMilkable() && SloadUtility.PawnIsThrall(__instance.parent as Pawn))
            {
                __result = false;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(CompShearable))]
    class CompShearable_Active_Patch
    {
        [HarmonyPrefix]
        [HarmonyPatch("Active", MethodType.Getter)]
        public static bool CompShearable_Active_SloadThrallFix(ref CompShearable __instance, ref bool __result)
        {
            if (ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallShearable() && SloadUtility.PawnIsThrall(__instance.parent as Pawn))
            {
                __result = false;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(CompEggLayer))]
    class CompEggLayer_Active_Patch
    {
        [HarmonyPrefix]
        [HarmonyPatch("Active", MethodType.Getter)]
        public static bool CompEggLayer_Active_SloadThrallFix(ref CompEggLayer __instance, ref bool __result)
        {
            if (ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallEggLaying() && SloadUtility.PawnIsThrall(__instance.parent as Pawn))
            {
                __result = false;
                return false;
            }
            return true;
        }
    }

}
