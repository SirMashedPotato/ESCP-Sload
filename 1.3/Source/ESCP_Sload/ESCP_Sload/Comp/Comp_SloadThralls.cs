using System;
using Verse;
using RimWorld;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace ESCP_Sload
{
    class Comp_SloadThralls : ThingComp
    {
        public List<Pawn> thralls = new List<Pawn>();

        public CompProperties_SloadThralls Props
        {
            get
            {
                return (CompProperties_SloadThralls)this.props;
            }
        }

        public override void PostExposeData()
        {
            base.PostExposeData();
            Scribe_Collections.Look(ref thralls, "ESCP_SloadThralls", LookMode.Reference);
        }

        public int ThrallCount()
        {
            return thralls.NullOrEmpty() ? 0 : thralls.Count();
        }

        public void AddThrall(Pawn pawn)
        {
            thralls.Add(pawn);
        }

        public void RemoveThrall(Pawn pawn)
        {
            thralls.Remove(pawn);
        }

        public void KillThralls()
        {
            while (thralls.Count() > 0)
            {
                thralls[0].Kill(null);
            }
        }

        public int CleanThrallList()
        {
            int count = 0;
            int num = ThrallCount();
            List<Pawn> temp = new List<Pawn>();

            for(int i = 0; i < num; i++)
            {
                try
                {
                    if (thralls[i].Name != null)
                    {
                        temp.Add(thralls[i]);
                    } 
                    else
                    {
                        count++;
                    }
                }
                catch (NullReferenceException)
                {
                    count++;
                }
            }
            thralls.Clear();
            thralls = temp;
            return count;
        }

        public override void CompTick()
        {
            base.CompTick();

            Pawn p = this.parent as Pawn;
            if (p.Downed && p.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ESCP_SloadThrassianElixir_ThrallControl) == null)
            {
                KillThralls();
            }
        }

        /* Gizmo stuff */

        public override IEnumerable<Gizmo> CompGetGizmosExtra()
        {
            yield return new Command_Action
            {
                defaultLabel = "ESCP_SloadThrall_KillAllThrall".Translate(),
                defaultDesc = "ESCP_SloadThrall_KillAllThrall_Tooltip".Translate(GetThrallList()),
                icon = ContentFinder<Texture2D>.Get("UI/Gizmos/ESCP_SloadDisbandThrall", true),
                disabled = thralls.Count <= 0,
                onHover = delegate ()
                {
                    ShowThralls();
                },
                action = delegate ()
                {
                    KillThralls();
                }
            };
        }

        public StringBuilder GetThrallList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (ThrallCount() == 0)
            {
                stringBuilder.Append("  - None");
            }
            for (int i = 0; i < ThrallCount(); i++)
            {
                if (stringBuilder.Length != 0)
                {
                    stringBuilder.AppendLine();
                }
                stringBuilder.Append("  - " + thralls[i].LabelNoCountColored.Resolve() + " (" + thralls[i].def.label + ")");
            }
            return stringBuilder;
        }

        public void ShowThralls()
        {
            LookTargets targets = new LookTargets(thralls);
            if (targets != null)
            {
                targets.Highlight(true, true, false);
            }
        }
    }
}
