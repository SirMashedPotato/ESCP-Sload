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

    //maxes out needs
    [HarmonyPatch(typeof(ThoughtHandler))]
    [HarmonyPatch("GetAllMoodThoughts")]
    public static class ThoughtHandler_GetAllMoodThoughts_Patch
    {
        [HarmonyPrefix]
        public static bool GetAllMoodThoughts_SloadThrallFix(ref Pawn ___pawn, List<Thought> outThoughts)
        {
            if (SloadUtility.PawnIsThrall(___pawn) && ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallDisableMoods())
            {
                outThoughts.Clear();
                return false;
            }
            return true;
        }
    }

}
