using System;
using Verse;
using RimWorld;
using System.Collections.Generic;
using System.Linq;

namespace ESCP_Sload
{
    class Gas_ThrassianPlague : Gas
    {
        private int tickerInterval = 0;
        private int tickerMax = 120;

        public override void Tick()
        {
            base.Tick();

            try
            {
                if (tickerInterval >= tickerMax)
                {
                    HashSet<Thing> hashSet = new HashSet<Thing>(Position.GetThingList(Map));
                    if (hashSet != null)
                    {
                        foreach (Thing thing in hashSet)
                        {
                            if (thing is Pawn)
                            {
                                Pawn p = thing as Pawn;
                                //TODO
                                //rework to use utility method, check anything else that can be reworked to use it
                                var props = SloadProperties.Get(p.def);
                                if (!p.RaceProps.IsFlesh || (props != null && props.thrassianPlagueImmune) || SloadUtility.PawnIsThrall(p))
                                {
                                    return;
                                }
                                if (ModsConfig.IdeologyActive)
                                {
                                    //TODO
                                    //rework to use a defOf that is only enabled if Ideo is enabled
                                    if (p.Ideo != null && p.Ideo.PreceptsListForReading.Where(x => x.def.defName == "ESCP_SloadThrassianImmunity_Immune").Any())
                                    {

                                    }
                                }

                                HealthUtility.AdjustSeverity(p, HediffDefOf.ESCP_ThrassianPlague, 0.025f);
                            }
                        }
                    }
                    tickerInterval = 0;
                }
                tickerInterval++;
            }
            catch (NullReferenceException)
            {

            }
        }
    }
}
