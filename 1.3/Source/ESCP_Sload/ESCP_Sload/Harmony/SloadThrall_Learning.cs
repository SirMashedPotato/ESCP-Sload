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
            if (SloadUtility.PawnIsThrall(___pawn) && ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallSkillLearning())
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
            if (SloadUtility.PawnIsThrall(___pawn) && ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallSkillDecay())
            {
                return false;
            }
            return true;
        }
    }

}
