using HarmonyLib;
using Verse;

namespace ESCP_Sload
{
    [HarmonyPatch(typeof(HediffGiver_Bleeding))]
    [HarmonyPatch("OnIntervalPassed")]
    class HediffGiver_Bleeding_OnIntervalPassed_Patch
    {
        [HarmonyPrefix]
        public static bool OnIntervalPassed_SloadThrallFix(Pawn pawn)
        {
            return !(ESCP_Sload_ModSettings.SloadThrallDisableBloodloss && SloadUtility.PawnIsThrall(pawn));
        }
    }

    [HarmonyPatch(typeof(HediffGiver_Hypothermia))]
    [HarmonyPatch("OnIntervalPassed")]
    class HediffGiver_Hypothermia_OnIntervalPassed_Patch
    {
        [HarmonyPrefix]
        public static bool OnIntervalPassed_SloadThrallFix(Pawn pawn)
        {
            return !(ESCP_Sload_ModSettings.SloadThrallDisableHypothermia && SloadUtility.PawnIsThrall(pawn));
        }
    }

    [HarmonyPatch(typeof(HediffGiver_Heat))]
    [HarmonyPatch("OnIntervalPassed")]
    class HediffGiver_Heat_OnIntervalPassed_Patch
    {
        [HarmonyPrefix]
        public static bool OnIntervalPassed_SloadThrallFix(Pawn pawn)
        {
            return !(ESCP_Sload_ModSettings.SloadThrallDisableHeatstroke && SloadUtility.PawnIsThrall(pawn));
        }
    }
}
