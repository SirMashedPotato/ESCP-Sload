using HarmonyLib;
using RimWorld;
using Verse;

namespace ESCP_Sload
{

    [HarmonyPatch(typeof(InspirationWorker))]
    [HarmonyPatch("InspirationCanOccur")]
    public static class InspirationWorker_InspirationCanOccur_Patch
    {
        [HarmonyPrefix]
        public static bool SloadInspirationCanOccurPatch(Pawn pawn, ref bool __result)
        {
            if ((ModSettingsUtility.ESCP_RaceTools_SloadInspirations() && pawn.def == ThingDefOf.ESCP_SloadRace) 
                || (ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallInspirations() && SloadUtility.PawnIsThrall(pawn)))
            {
                return false;
            }
            return true;
        }
    }

}
