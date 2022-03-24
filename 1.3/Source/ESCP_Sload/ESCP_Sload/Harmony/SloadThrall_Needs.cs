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
        public static bool CurLevelInt_SloadThrallFix(ref Need __instance, ref Pawn ___pawn, ref float __result)
        {
            if (SloadUtility.PawnIsThrall(___pawn) && ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallDisableNeeds())
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
    class Need_CurLevelPercentage_Patch
    {
        [HarmonyPrefix]
        [HarmonyPatch("CurLevelPercentage", MethodType.Getter)]
        public static bool CurLevelPercentage_SloadThrallFix(ref Need __instance, ref Pawn ___pawn, ref float __result)
        {
            if (SloadUtility.PawnIsThrall(___pawn) && ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallDisableNeeds())
            {
                if (__instance.def.defName != "TM_Mana" && __instance.def.defName != "TM_Stamina")
                {
                    __result = 1f;
                    return false;
                }
            }
            return true;
        }
    }

}
