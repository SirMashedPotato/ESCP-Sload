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
            if ((ESCP_Sload_ModSettings.SloadInspirations && pawn.def == ThingDefOf.ESCP_SloadRace) 
                || (ESCP_Sload_ModSettings.SloadThrallInspirations && SloadUtility.PawnIsThrall(pawn)))
            {
                return false;
            }
            return true;
        }
    }

}
