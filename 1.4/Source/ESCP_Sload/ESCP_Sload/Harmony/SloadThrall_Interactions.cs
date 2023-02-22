using HarmonyLib;
using Verse;
using RimWorld;

namespace ESCP_Sload
{
    [HarmonyPatch(typeof(InteractionUtility))]
    [HarmonyPatch("CanInitiateInteraction")]
    public static class InteractionUtility_CanInitiateInteraction_Patch
    {
        [HarmonyPostfix]
        public static void CanInitiateInteraction_ThrallFix(ref bool __result, Pawn pawn, InteractionDef interactionDef = null)
        {
            if (__result && ESCP_Sload_ModSettings.SloadThrallDisableSocialInteractions && SloadUtility.PawnIsThrall(pawn))
            {
                if (interactionDef == RimWorld.InteractionDefOf.Insult || interactionDef == RimWorld.InteractionDefOf.RomanceAttempt
                    || interactionDef == RimWorld.InteractionDefOf.Chitchat || interactionDef == RimWorld.InteractionDefOf.DeepTalk
                    || interactionDef == InteractionDefOf.KindWords || interactionDef == InteractionDefOf.Slight)
                {
                    __result = false;
                }
            }
        }
    }
}
