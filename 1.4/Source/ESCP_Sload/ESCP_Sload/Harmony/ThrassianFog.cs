using HarmonyLib;
using RimWorld;
using Verse;
using System.Collections.Generic;

namespace ESCP_Sload
{

    [HarmonyPatch(typeof(IncidentWorker_RaidEnemy))]
    [HarmonyPatch("GenerateRaidLoot")]
    public static class IncidentWorker_RaidEnemy_GenerateRaidLoot_Patch
    {
        [HarmonyPostfix]
        public static void SloadThrassianFogPatch(IncidentParms parms, List<Pawn> pawns)
        {
            if (parms.target is Map)
            {
                Map map = parms.target as Map;
                if (map.GetComponent<MapComp_ThrassianMiasma>().IsActive())
                {
                    foreach (Pawn p in pawns)
                    {
                        var props = ESCP_RaceTools.RaceProperties.Get(p.def);
                        if ((props == null || !props.thrassianPlagueImmune) && p.RaceProps.IsFlesh)
                        {
                            p.health.AddHediff(HediffDefOf.ESCP_ThrassianPlague).Severity = Rand.Range(0f, 0.25f);
                        }
                    }
                }
            }
        }
    }
    /*
    [HarmonyPatch(typeof(SkyManager))]
    [HarmonyPatch("CurrentSkyTarget")]
    public static class SkyManager_CurrentSkyTarget_Patch
    {
        [HarmonyPostfix]
        public static void SloadThrassianFogPatch(ref Map ___map, ref SkyTarget __result)
        {
            if (true)
            {
                if (___map.GetComponent<MapComp_ThrassianMiasma>().IsActive())
                {
                    Color oldColor = __result.colors.sky;
                    Color newColor = new Color(oldColor.r, oldColor.g - 0.05f, oldColor.b);
                    __result.colors.sky = newColor;
                }
            }
        }
    }
    */
}
