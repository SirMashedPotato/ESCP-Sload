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

    [HarmonyPatch(typeof(CompMilkable))]
    class CompMilkable_Active_Patch
    {
        [HarmonyPrefix]
        [HarmonyPatch("Active", MethodType.Getter)]
        public static bool CompMilkable_Active_SloadThrallFix(ref CompMilkable __instance, ref bool __result)
        {
            if (SloadUtility.PawnIsThrall(__instance.parent as Pawn) && ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallMilkable())
            {
                __result = false;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(CompShearable))]
    class CompShearable_Active_Patch
    {
        [HarmonyPrefix]
        [HarmonyPatch("Active", MethodType.Getter)]
        public static bool CompShearable_Active_SloadThrallFix(ref CompShearable __instance, ref bool __result)
        {
            if (SloadUtility.PawnIsThrall(__instance.parent as Pawn) && ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallShearable())
            {
                __result = false;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(CompEggLayer))]
    class CompEggLayer_Active_Patch
    {
        [HarmonyPrefix]
        [HarmonyPatch("Active", MethodType.Getter)]
        public static bool CompEggLayer_Active_SloadThrallFix(ref CompEggLayer __instance, ref bool __result)
        {
            if (SloadUtility.PawnIsThrall(__instance.parent as Pawn) && ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallEggLaying())
            {
                __result = false;
                return false;
            }
            return true;
        }
    }

}
