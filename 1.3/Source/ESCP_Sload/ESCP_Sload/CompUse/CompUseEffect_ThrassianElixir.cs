using System;
using Verse;
using RimWorld;

namespace ESCP_Sload
{
    class CompUseEffect_ThrassianElixir : CompUseEffect_Artifact
	{
		new public CompProperties_UseEffectThrassianElixir Props
		{
			get
			{
				return (CompProperties_UseEffectThrassianElixir)this.props;
			}
		}

		public override void DoEffect(Pawn usedBy)
		{
			base.DoEffect(usedBy);
			if(usedBy.def == ThingDefOf.ESCP_SloadRace && usedBy.health.hediffSet.GetFirstHediffOfDef(Props.hediff) == null)
            {
				usedBy.health.AddHediff(Props.hediff);
            } 
			else
            {
                if (!usedBy.RaceProps.IsMechanoid)
                {
					GenExplosion.DoExplosion(usedBy.Position, usedBy.Map, 3, DamageDefOf.Extinguish, usedBy, -1, -1f, null, null, null, null, ThingDefOf.ESCP_Gas_ThrassianPlague, 1f, 1, false, null, 0f, 1, 0f, false, null, null);
					usedBy.Kill(null);
				}
			}
		}

		public override bool CanBeUsedBy(Pawn p, out string failReason)
		{
			if (p.health.hediffSet.GetFirstHediffOfDef(Props.hediff) != null)
			{
				failReason = "ESCP_Sload_AlreadyHasHediff".Translate(p.Name, this.parent.Label);
				return false;
			}
			return base.CanBeUsedBy(p, out failReason);
		}
	}
}
