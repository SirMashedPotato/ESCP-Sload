﻿using System;
using Verse;
using RimWorld;

namespace ESCP_Sload
{
    class ThoughtWorker_Situational_Precept_SloadInMap : ThoughtWorker_Precept
    {
        protected override ThoughtState ShouldHaveThought(Pawn p)
        {
            return p.IsColonist && !p.IsSlave && !p.IsPrisoner && SloadUtility.SloadsInMap(p.Map) > 0;
        }
    }
}