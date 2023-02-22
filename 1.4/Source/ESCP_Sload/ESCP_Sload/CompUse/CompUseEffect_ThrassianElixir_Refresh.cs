using System;
using Verse;
using RimWorld;

namespace ESCP_Sload
{
    class CompUseEffect_ThrassianElixir_Refresh : CompUseEffect_Artifact
	{
		new public CompProperties_UseEffectThrassianElixir_Refresh Props
		{
			get
			{
				return (CompProperties_UseEffectThrassianElixir_Refresh)this.props;
			}
		}

		public override void DoEffect(Pawn usedBy)
		{
			base.DoEffect(usedBy);
			if (usedBy.def == ThingDefOf.ESCP_SloadRace && usedBy.abilities.abilities.Find(x => x.def == Props.ability) != null)
			{
				Ability a = usedBy.abilities.abilities.Find(x => x.def == Props.ability);
				a.StartCooldown(0);
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
			if (p.abilities.abilities.Find(x=>x.def == Props.ability) != null)
			{
				Ability a = p.abilities.abilities.Find(x => x.def == Props.ability);
				if (a.CooldownTicksRemaining > 0)
                {
					return base.CanBeUsedBy(p, out failReason);
				}
			}
			failReason = "ESCP_Sload_AlreadyHasHediff".Translate(p.Name, this.parent.Label);
			return false;
		}
	}
}
