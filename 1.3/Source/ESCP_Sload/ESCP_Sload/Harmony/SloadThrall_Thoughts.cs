using HarmonyLib;
using RimWorld;
using Verse;
using System;
using System.Collections.Generic;

namespace ESCP_Sload
{

    //disable all thoughts
    [HarmonyPatch(typeof(ThoughtHandler))]
    [HarmonyPatch("GetSocialThoughts")]
    [HarmonyPatch(new Type[] { typeof(Pawn), typeof(ISocialThought), typeof(List<ISocialThought>) })]
    public static class ThoughtHandler_GetSocialThoughts_Patch
    {
        [HarmonyPrefix]
        public static bool GetSocialThoughts_SloadThrallFix(ref Pawn ___pawn, List<ISocialThought> outThoughts)
        {
            if (SloadUtility.PawnIsThrall(___pawn) && ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallDisableMoods())
            {
                outThoughts.Clear();
                return false;
            }
            return true;
        }
    }

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
