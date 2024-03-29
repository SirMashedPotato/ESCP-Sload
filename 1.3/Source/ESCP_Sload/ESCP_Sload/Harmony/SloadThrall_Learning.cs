﻿using HarmonyLib;
using RimWorld;
using Verse;

namespace ESCP_Sload
{

    //skill learning
    [HarmonyPatch(typeof(SkillRecord))]
    [HarmonyPatch("Learn")]
    public static class Interval_Learn_Patch
    {
        [HarmonyPrefix]
        public static bool SkillRecord_Learn_SloadThrallFix(ref Pawn ___pawn)
        {
            if (ESCP_Sload_ModSettings.SloadThrallSkillLearning && SloadUtility.PawnIsThrall(___pawn))
            {
                return false;
            }
            return true;
        }
    }

    //Skill decay
    [HarmonyPatch(typeof(SkillRecord))]
    [HarmonyPatch("Interval")]
    public static class Interval_Interval_Patch
    {
        [HarmonyPrefix]
        public static bool SkillRecord_Interval_SloadThrallFix(ref Pawn ___pawn)
        {
            if (ESCP_Sload_ModSettings.SloadThrallSkillDecay && SloadUtility.PawnIsThrall(___pawn))
            {
                return false;
            }
            return true;
        }
    }

}
