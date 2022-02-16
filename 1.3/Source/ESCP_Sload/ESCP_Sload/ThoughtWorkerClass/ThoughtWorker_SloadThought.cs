using RimWorld;
using Verse;

namespace ESCP_Sload
{
    class ThoughtWorker_SloadThought : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            return p.def == ThingDefOf.ESCP_SloadRace;
        }
    }
}
