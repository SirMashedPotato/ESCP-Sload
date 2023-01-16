using RimWorld;
using Verse;

namespace ESCP_Sload
{
    class ThoughtWorker_SloadOpinionThought : ThoughtWorker_Precept_Social
    {
        protected override ThoughtState ShouldHaveThought(Pawn p, Pawn otherPawn)
        {
            return otherPawn.def == ThingDefOf.ESCP_SloadRace;
        }
    }
}
