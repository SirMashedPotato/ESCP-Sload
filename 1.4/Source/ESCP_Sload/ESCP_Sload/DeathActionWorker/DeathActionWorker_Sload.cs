using System;
using Verse;
using RimWorld;
using System.Collections.Generic;
using System.Linq;
using ESCP_RaceTools;

namespace ESCP_Sload
{
    class DeathActionWorker_Sload : ESCP_RaceTools.DeathActionWorker_HistoryEventOnDeath
    {
        public override void PawnDied(Corpse corpse)
        {
            corpse.InnerPawn.GetComp<Comp_SloadThralls>().KillThralls();
            base.PawnDied(corpse);
        }
    }
}
