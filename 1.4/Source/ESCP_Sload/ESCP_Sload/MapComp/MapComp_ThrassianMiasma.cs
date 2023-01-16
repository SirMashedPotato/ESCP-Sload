using System;
using System.Collections.Generic;
using RimWorld;
using Verse;

namespace ESCP_Sload
{
    class MapComp_ThrassianMiasma : MapComponent
    {
        public MapComp_ThrassianMiasma(Map map) : base(map)
        {
        }

		public override void MapComponentTick()
		{
			base.MapComponentTick();
            if (daysLeft > 0)
            {
                currentTicks++;
                if (currentTicks >= targetTicks)
                {
                    daysLeft--;
                    currentTicks = 0;
                }
            }
		}

        public void IncreaseDays(int days)
        {
            daysLeft += days;
        }

        public int GetDays()
        {
            return daysLeft;
        }

        public bool IsActive()
        {
            return daysLeft > 0;
        }

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref this.daysLeft, "ESCP_Sload_MiasmaDaysLeft", 0);
            Scribe_Values.Look(ref this.currentTicks, "ESCP_Sload_MiasmaTicks", 0);
            base.ExposeData();
        }

        public int daysLeft = 0;

        private int currentTicks = 0;
        private static readonly int targetTicks = 60000;   //a day
    }
}
