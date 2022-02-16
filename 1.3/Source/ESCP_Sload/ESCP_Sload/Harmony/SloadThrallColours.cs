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
    //Make thrall names purple, becuase why not?

    public static class ThrallTextColour
    {
        public static Color thrallTextColor =  new Color(0.8f, 0.6f, 1.0f);
    }

    [HarmonyPatch(typeof(PawnNameColorUtility))]
    [HarmonyPatch("PawnNameColorOf")]
    public static class PawnNameColorUtility_PawnNameColorOf_Patch
    {
        [HarmonyPrefix]
        public static bool PawnNameColorOf_SloadThrallFix(ref Pawn pawn, ref Color __result)
        {
            if (SloadUtility.PawnIsThrall(pawn) && ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallNamesArePurple())
            {
                __result = ThrallTextColour.thrallTextColor;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(PawnColumnWorker_Label))]
    [HarmonyPatch("DoCell")]
    public static class PawnColumnWorker_Label_DoCell_Patch
    {
        [HarmonyTranspiler]
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            if (ModSettingsUtility_SloadThralls.ESCP_RaceTools_SloadThrallNamesArePurple())
            {
                var codes = new List<CodeInstruction>(instructions);
                //used for checking for the right function call
                var target = AccessTools.Method(typeof(Widgets), nameof(Widgets.Label), new Type[] { typeof(Rect), typeof(string) });
                //function that is called
                var isThrall = AccessTools.Method(typeof(SloadUtility), nameof(SloadUtility.ThrallColourChanger));

                //find the right position in the stack
                for (int i = 0; i < codes.Count; i++)
                {
                    if (codes[i].opcode == OpCodes.Call && codes[i].operand == target)
                    {
                        var original = codes[i];    //store original method, return after
                        //loc 2 = rectangle
                        //loc 1 = string
                        yield return new CodeInstruction(OpCodes.Ldarg_2); //load pawn
                        yield return new CodeInstruction(OpCodes.Call, isThrall);   //add in custom check
                        yield return original;

                    }
                    else
                    {
                        yield return codes[i];
                    }
                }
            }
        }
    }
}