using System;
using Verse;
using RimWorld;
using System.Collections.Generic;
using UnityEngine;

namespace ESCP_Sload
{
    class CompAbilityEffect_ReleaseThrassianFog : CompAbilityEffect
    {
        public new CompProperties_ReleaseThrassianFog Props
        {
            get
            {
                return (CompProperties_ReleaseThrassianFog)this.props;
            }
        }

		public override IEnumerable<PreCastAction> GetPreCastActions()
		{
			if (true)
			{
				yield return new PreCastAction
				{
					action = delegate (LocalTargetInfo t, LocalTargetInfo d)
					{
						Log.Message("Baaaaa");
					},
				};
			}
			yield break;
		}

		public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
        {
            parent.pawn.Map.GetComponent<MapComp_ThrassianMiasma>().IncreaseDays(Props.days);
        }
    }
}
