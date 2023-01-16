using HarmonyLib;
using Verse;
using AnimalBehaviours;

namespace ESCP_Sload
{
    [HarmonyPatch(typeof(CompAnimalProduct))]
    class VEF_CompAnimalProduct_Active_Patch
    {
        [HarmonyPrefix]
        [HarmonyPatch("Active", MethodType.Getter)]
        public static bool CompAnimalProduct_Active_SloadThrallFix(ref CompAnimalProduct __instance, ref bool __result)
        {
            if (ESCP_Sload_ModSettings.SloadThrallVEF_AnimalProducts && SloadUtility.PawnIsThrall(__instance.parent as Pawn))
            {
                __result = false;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(CompAsexualReproduction))]
    [HarmonyPatch("CompTick")]
    public static class VEF_CompAsexualReproduction_CompTick_Patch
    {
        [HarmonyPrefix]
        public static bool CompAsexualReproduction_SloadThrallFix(ref CompAsexualReproduction __instance)
        {
            if (ESCP_Sload_ModSettings.SloadThrallVEF_AsexualReproduction && SloadUtility.PawnIsThrall(__instance.parent as Pawn))
            {
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(CompAsexualReproduction))]
    [HarmonyPatch("CompInspectStringExtra")]
    public static class VEF_CompAsexualReproduction_CompInspectStringExtra_Patch
    {
        [HarmonyPrefix]
        public static bool CompAsexualReproduction_SloadThrallFix(ref CompAsexualReproduction __instance, ref string __result)
        {
            if (ESCP_Sload_ModSettings.SloadThrallVEF_AsexualReproduction && SloadUtility.PawnIsThrall(__instance.parent as Pawn))
            {
                __result = "VFE_AsexualReproductionDisabled".Translate();
                return false;
            }
            return true;
        }
    }
}
