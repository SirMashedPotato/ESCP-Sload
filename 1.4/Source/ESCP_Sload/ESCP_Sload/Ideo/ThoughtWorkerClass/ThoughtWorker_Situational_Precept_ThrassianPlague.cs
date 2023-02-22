using System;
using Verse;
using RimWorld;
using System.Collections.Generic;
using System.Linq;

namespace ESCP_Sload
{
    class ThoughtWorker_Situational_Precept_ThrassianPlague : ThoughtWorker_Precept
    {
        protected override ThoughtState ShouldHaveThought(Pawn p)
        {
            return p.IsColonist && !p.IsSlave && !p.IsPrisoner && p.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ESCP_ThrassianPlague) != null;
        }
    }
}