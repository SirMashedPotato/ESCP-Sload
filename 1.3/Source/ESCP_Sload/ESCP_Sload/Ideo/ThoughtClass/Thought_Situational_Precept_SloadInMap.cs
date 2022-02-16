using System;
using Verse;
using RimWorld;

namespace ESCP_Sload
{
    class Thought_Situational_Precept_SloadInMap : Thought_Situational
    {
        public override float MoodOffset()
        {
            return this.BaseMoodOffset * (float)SloadUtility.SloadsInMap(this.pawn.Map);
        }
    }
}



