﻿using HarmonyLib;
using RimWorld;
using Verse;

namespace ESCP_Sload
{

    //can train
    [HarmonyPatch(typeof(Pawn_TrainingTracker))]
    [HarmonyPatch("CanBeTrained")]
    public static class Pawn_TrainingTracker_CanBeTrained_Patch
    {
        [HarmonyPrefix]
        public static bool CanBeTrained_SloadThrallFix(ref Pawn ___pawn, ref bool __result)
        {
            if (ESCP_Sload_ModSettings.SloadThrallTrainable && SloadUtility.PawnIsThrall(___pawn))
            {
                __result = false;
                return false;
            }
            return true;
        }
    }

    //training decay
    [HarmonyPatch(typeof(Pawn_TrainingTracker))]
    [HarmonyPatch("TrainingTrackerTickRare")]
    public static class Pawn_TrainingTrackerTickRare_Patch
    {
        [HarmonyPrefix]
        public static bool TrainingTrackerTickRare_SloadThrallFix(ref Pawn ___pawn)
        {
            if (ESCP_Sload_ModSettings.SloadThrallTrainableDecay && SloadUtility.PawnIsThrall(___pawn))
            {
                return false;
            }
            return true;
        }
    }

}
