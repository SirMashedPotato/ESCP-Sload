using Verse;
using RimWorld;

namespace ESCP_Sload
{
    public static class DebugTools
    {
		[DebugAction("ESCP - Sload", "Clean Missing Sload Thralls", false, false, actionType = DebugActionType.ToolMapForPawns, allowedGameStates = AllowedGameStates.PlayingOnMap)]
		private static void Sload_CleanThrallList(Pawn p)
		{
            if (p.def == ThingDefOf.ESCP_SloadRace)
            {
                Comp_SloadThralls comp = p.GetComp<Comp_SloadThralls>();
                int num = comp.CleanThrallList();
                Messages.Message("ESCP_Sload_CleanThrallList".Translate(p.NameFullColored, num), MessageTypeDefOf.NeutralEvent, false);
            }
		}
    }
}
