using RimWorld;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Verse;

namespace ESCP_Sload
{
	class HediffComp_SloadThrall : HediffComp
	{
		public Pawn Master
		{
			get
			{
				return this.master;
			}
		}

		public void SetMaster(Pawn p)
		{
			if (p != null)
			{
				this.master = p;
			}
		}

		public override void CompExposeData()
		{
			base.CompExposeData();
			Scribe_References.Look(ref this.master, "master", false);
		}

		public override void Notify_PawnDied()
		{
			master.GetComp<Comp_SloadThralls>().RemoveThrall(base.Pawn);
			base.Notify_PawnDied();
			base.Pawn.health.RemoveHediff(this.parent);
		}

		private static List<IntVec3> tmpCells = new List<IntVec3>();

		public override IEnumerable<Gizmo> CompGetGizmos()
		{
			yield return new Command_Action
			{
				defaultLabel = "ESCP_SloadThrall_KillThrall".Translate(),
				defaultDesc = "ESCP_SloadThrall_KillThrall_Tooltip".Translate(this.master.Name),
				icon = ContentFinder<Texture2D>.Get("UI/Gizmos/ESCP_SloadDisbandThrall", true),
				onHover = delegate ()
				{
					ShowSload();
				},
				action = delegate ()
				{
					this.Pawn.Kill(null);
				}
			};

			if (SloadUtility.SloadIsPlagueLord(Master))
			{
				yield return new Command_Action
				{
					defaultLabel = "ESCP_SloadThrall_KillThrall_PlagueLord".Translate(),
					defaultDesc = "ESCP_SloadThrall_KillThrall_PlagueLord_Tooltip".Translate(this.master.Name),
					icon = ContentFinder<Texture2D>.Get("UI/Gizmos/ESCP_SloadDisbandThrall_Miasma", true),
					onHover = delegate ()
                    {
						tmpCells.Clear();
						int num = GenRadial.NumCellsInRadius(3);
						for (int i = 0; i < num; i++)
						{
							IntVec3 intVec = this.Pawn.Position + GenRadial.RadialPattern[i];
							tmpCells.Add(intVec);
						}
						GenDraw.DrawFieldEdges(tmpCells);
						ShowSload();
					},
					action = delegate ()
					{
						SloadUtility.DoThrassianGasExplosion(Pawn, 3);
						this.Pawn.Kill(null);
					}
				};
			}
		}

		public void ShowSload()
		{
			LookTargets target = new LookTargets(Master);
			if (target != null)
			{
				target.Highlight(true, true, false);
			}
		}

		int ticks = 0;

		public override void CompPostTick(ref float severityAdjustment)
		{
			base.CompPostTick(ref severityAdjustment);
			ticks++;
            if (ticks >= 500)
            {
				if (this.Pawn.Faction == null || this.Pawn.Faction != Faction.OfPlayer || Master.Destroyed)
				{
					this.Pawn.Kill(null);
				}
				ticks = 0;
			}
		}

        public override void CompPostPostRemoved()
        {
			master.GetComp<Comp_SloadThralls>().RemoveThrall(base.Pawn);
			base.CompPostPostRemoved();
		}

        public override string CompLabelInBracketsExtra => master != null ? master.Name.ToString() : null;

		private Pawn master = null;
	}
}
