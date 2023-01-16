using System.Linq;
using RimWorld.Planet;
using Verse;
using RimWorld;

namespace ESCP_Sload
{
    class IncidentWorker_ThrassianPlague : IncidentWorker_DiseaseHuman
    {
        protected override bool CanFireNowSub(IncidentParms parms)
        {
            return ESCP_Sload_ModSettings.SloadThrassianPlagueIncident && this.PotentialVictims(parms.target).Any() && !Immune() && Hostile();
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
                var props = SloadProperties.Get(f.def);
                if (props != null && props.isSloadFaction && f.HostileTo(Faction.OfPlayer))
                {

                    return true;
                }
            }
            return false;
        }
    }
}
