﻿using System;
using Verse;
using RimWorld;
using System.Collections.Generic;
using Verse.AI;
using UnityEngine;
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
                    HashSet<Thing> hashSet = new HashSet<Thing>(this.Position.GetThingList(this.Map));
                    if (hashSet != null)
                    {
                        foreach (Thing thing in hashSet)
                        {
                            if (thing is Pawn)
                            {
                                Pawn p = thing as Pawn;
                                var props = ESCP_RaceTools.RaceProperties.Get(p.def);
                                if (!p.RaceProps.IsFlesh || (props != null && props.thrassianPlagueImmune)
                                    || SloadUtility.PawnIsThrall(p)
                                    || (p.Ideo != null && p.Ideo.PreceptsListForReading.Where(x => x.def.defName == "ESCP_SloadThrassianImmunity_Immune").Any()))
                                {
                                    return;
                                }

                                HealthUtility.AdjustSeverity(p, HediffDefOf.ESCP_ThrassianPlague, 0.025f);
                            }
                        }
                    }
                    tickerInterval = 0;
                }
                tickerInterval++;
            }
            catch (NullReferenceException e)
            {

            }
        }
    }
}
