using System;
using Verse;
using RimWorld;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ESCP_Sload
{
    public static class SloadUtility
    {

        public static int SloadsInFaction(Faction faction)
        {
            if (faction == null)
            {
                return 0;
            }
            int num = 0;
            using (List<Pawn>.Enumerator enumerator = PawnsFinder.AllMaps_SpawnedPawnsInFaction(faction).GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    if (enumerator.Current != null && enumerator.Current.def == ThingDefOf.ESCP_SloadRace)
                    {
                        num++;
                    }
                }
            }
            return num;
        }

        public static int SloadsInMap(Map map)
        {
            if (map == null)
            {
                return 0;
            }
            int num = 0;
            using (List<Pawn>.Enumerator enumerator = map.mapPawns.AllPawnsSpawned.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    if (enumerator.Current != null && enumerator.Current.def == ThingDefOf.ESCP_SloadRace)
                    {
                        num++;
                    }
                }
            }
            return num;
        }

        public static bool ThingIsThrall(Thing t)
        {
            return t is Pawn p && PawnIsThrall(p);
        }

        public static bool PawnIsThrall(Pawn p)
        {
            return p.health != null && p.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ESCP_SloadThrallPassive) != null;
        }

        public static bool SloadIsPlagueLord(Pawn p)
        {
            return p.health != null && p.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ESCP_SloadPlagueLord) != null;
        }

    }
}
