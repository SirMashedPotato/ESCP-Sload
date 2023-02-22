using System.Linq;
using RimWorld.Planet;
using Verse;
using RimWorld;
using ESCP_RaceTools;

namespace ESCP_Sload
{
    class IncidentWorker_ThrassianPlague : IncidentWorker_DiseaseHuman
    {
        protected override bool CanFireNowSub(IncidentParms parms)
        {
            return ESCP_Sload_ModSettings.SloadThrassianPlagueIncident && PotentialVictims(parms.target).Any<Pawn>() && !Immune() && Hostile();
        }

        private bool Immune()
        {
            return Faction.OfPlayer.ideos.PrimaryIdeo.PreceptsListForReading.Where(x => x.def.defName == "ESCP_SloadThrassianImmunity_Immune").Any();
        }

        private bool Hostile()
        {
            World world = Find.World;
            foreach (Faction f in world.factionManager.GetFactions().InRandomOrder())
            {
                FactionProperties props = FactionProperties.Get(f.def);
                if (props != null && props.factionTags.Contains("ESCP_SloadFaction") && f.HostileTo(Faction.OfPlayer))
                {

                    return true;
                }
            }
            return false;
        }
    }
}
