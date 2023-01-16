using System;
using System.Collections.Generic;
using RimWorld;
using RimWorld.Planet;
using UnityEngine;
using Verse;

namespace ESCP_Sload
{
    class Alert_ThrassianFog : Alert
    {
        public Alert_ThrassianFog()
        {
            this.defaultLabel = "ESCP_Sload_Alert_ThrassianFog".Translate();
            this.defaultPriority = AlertPriority.Medium;
        }

        private int MapHasFog()
        {
            Map map = Find.CurrentMap;
            return map == null ? 0 : map.GetComponent<MapComp_ThrassianMiasma>().daysLeft;
        }

        public override AlertReport GetReport()
        {
            return ESCP_Sload_ModSettings.SloadThrassianFogAlert && MapHasFog() > 0 ? AlertReport.Active : AlertReport.Inactive;
        }

        public override TaggedString GetExplanation()
        {
            return "ESCP_Sload_Alert_ThrassianFogDescription".Translate(MapHasFog());
        }
    }
}
