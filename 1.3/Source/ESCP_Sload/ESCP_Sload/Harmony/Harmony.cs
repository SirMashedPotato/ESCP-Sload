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


namespace ESCP_Sload
{
    //Setting the Harmony instance
    [StaticConstructorOnStartup]
    public class Main
    {
        static Main()
        {
            var harmony = new Harmony("com.ESCP_Sload");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }

    [HarmonyPatch(typeof(Pawn_PlayerSettings))]
    public static class Pawn_PlayerSettings_UsesConfigurableHostilityResponse_Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch("UsesConfigurableHostilityResponse", MethodType.Getter)]
        public static void UsesConfigurableHostilityResponse_ThrallPatch(ref bool __result, ref Pawn ___pawn)
        {
            if (SloadUtility.PawnIsThrall(___pawn) && ___pawn.RaceProps.Animal)
            {
                __result = true;
                return;
            }
        }
    }
}

