using HarmonyLib;
using RimWorld;
using System.Reflection;
using Verse;
using Verse.AI;
using Verse.AI.Group;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Linq;
using RimWorld.Planet;
using UnityEngine;
using ESCP_RaceTools;

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
            if (SloadUtility.PawnIsThrall(___pawn) && ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallTrainable())
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
            if (SloadUtility.PawnIsThrall(___pawn) && ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallTrainableDecay())
            {
                return false;
            }
            return true;
        }
    }

}
