using RimWorld;
using Verse;

namespace ESCP_Sload
{
    class ThoughtWorker_SloadThrallThought : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            return SloadUtility.PawnIsThrall(p);
        }
    }
}
