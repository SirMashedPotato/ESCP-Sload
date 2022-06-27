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
            if (ESCP_Sload_ModSettings.SloadThrallDisableMoods && SloadUtility.PawnIsThrall(___pawn))
            {
                outThoughts.Clear();
                return false;
            }
            return true;
        }
    }
    /* Ye Olde patch
    [HarmonyPatch(typeof(ThoughtHandler))]
    [HarmonyPatch("GetAllMoodThoughts")]
    public static class ThoughtHandler_GetAllMoodThoughts_Patch
    {
        [HarmonyPrefix]
        public static bool GetAllMoodThoughts_SloadThrallFix(ref Pawn ___pawn, List<Thought> outThoughts)
        {
            if (ESCP_Sload_ModSettings.SloadThrallDisableMoods && SloadUtility.PawnIsThrall(___pawn))
            {
                outThoughts.Clear();
                return false;
            }
            return true;
        }
    }
    */
    [HarmonyPatch(typeof(SituationalThoughtHandler))]
    [HarmonyPatch("AppendMoodThoughts")]
    public static class SituationalThoughtHandler_AppendMoodThoughts_Patch
    {
        [HarmonyPostfix]
        public static void AppendMoodThoughts_SloadThrallFix(List<Thought> outThoughts)
        {
            if (ESCP_Sload_ModSettings.SloadThrallDisableMoods && outThoughts.Find(x=>x.def == ThoughtDefOf.ESCP_SloadThrallThought) != null)
            {
                Thought temp = outThoughts.Find(x => x.def == ThoughtDefOf.ESCP_SloadThrallThought);
                outThoughts.Clear();
                outThoughts.Add(temp);
            }
        }
    }
}
