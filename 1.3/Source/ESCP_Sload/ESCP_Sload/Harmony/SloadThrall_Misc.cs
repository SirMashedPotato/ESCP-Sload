using HarmonyLib;
using RimWorld;
using Verse;

namespace ESCP_Sload
{

    //Prevents ideo certainty decay
    [HarmonyPatch(typeof(Pawn_IdeoTracker))]
    class Pawn_IdeoTracker_CertaintyChangePerDay_Patch
    {
        [HarmonyPrefix]
        [HarmonyPatch("CertaintyChangePerDay", MethodType.Getter)]
        public static bool CertaintyChangePerDay_SloadThrallFix(ref Pawn ___pawn, ref float __result)
        {
            if (ESCP_Sload_ModSettings.SloadThrallIdeoCertainty && SloadUtility.PawnIsThrall(___pawn))
            {
                __result = 1f;
                return false;
            }
            return true;
        }
    }

}
