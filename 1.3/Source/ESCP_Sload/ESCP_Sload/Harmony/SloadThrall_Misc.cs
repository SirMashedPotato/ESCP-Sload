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

    //Prevents ideo certainty decay
    [HarmonyPatch(typeof(Pawn_IdeoTracker))]
    class Pawn_IdeoTracker_CertaintyChangePerDay_Patch
    {
        [HarmonyPrefix]
        [HarmonyPatch("CertaintyChangePerDay", MethodType.Getter)]
        public static bool CertaintyChangePerDay_SloadThrallFix(ref Pawn ___pawn, ref float __result)
        {
            if (SloadUtility.PawnIsThrall(___pawn) && ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallIdeoCertainty())
            {
                __result = 1f;
                return false;
            }
            return true;
        }
    }

}
