using HarmonyLib;
using RimWorld;
using Verse;

namespace ESCP_Sload
{

    //maxes out needs
    [HarmonyPatch(typeof(Need))]
    class Need_CurLevel_Patch
    {
        [HarmonyPrefix]
        [HarmonyPatch("CurLevel", MethodType.Getter)]
        public static bool CurLevel_SloadThrallFix(ref Need __instance, ref Pawn ___pawn, ref float __result)
        {
            if (ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallDisableNeeds() && SloadUtility.PawnIsThrall(___pawn))
            {
                if (__instance.def.defName != "TM_Mana" && __instance.def.defName != "TM_Stamina")
                {
                    __result = __instance.MaxLevel;
                    return false;
                }
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(Need))]
    class Need_CurInstantLevel_Patch
    {
        [HarmonyPrefix]
        [HarmonyPatch("CurInstantLevel", MethodType.Getter)]
        public static bool CurInstantLevel_SloadThrallFix(ref Need __instance, ref Pawn ___pawn, ref float __result)
        {
            if (ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallDisableNeeds() && SloadUtility.PawnIsThrall(___pawn))
            {
                if (__instance.def.defName != "TM_Mana" && __instance.def.defName != "TM_Stamina")
                {
                    __result = __instance.MaxLevel;
                    return false;
                }
            }
            return true;
        }
    }

}
