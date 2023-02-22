using Verse;
using RimWorld;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace ESCP_Sload
{
    class CompAbilityEffect_SloadThrallImproveSkill : CompAbilityEffect
    {
        public new CompProperties_SloadThrallImproveSkill Props
        {
            get
            {
                return (CompProperties_SloadThrallImproveSkill)this.props;
            }
        }

        public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
        {
            Thing t = target.Thing;
            if (t != null && t is Pawn thrall)
            {
                Pawn p = parent.pawn;
                int skillLevel = p.skills.GetSkill(Props.skill ?? SkillDefOf.Intellectual).Level;
                float chance = Props.chancePerLevel * skillLevel;
                List<SkillRecord> list = thrall.skills.skills.Where(x=>!x.TotallyDisabled).ToList();
                foreach(SkillRecord sr in list)
                {
                    bool flag = ESCP_Sload_ModSettings.SloadThrallSkillLimit;
                    int temp = !flag ? Mathf.Clamp(sr.levelInt + 1, 1, 20) : sr.levelInt + 1;
                    switch (sr.passion)
                    {
                        case Passion.Major:
                            sr.levelInt = temp;
                            break;
                        case Passion.Minor:
                            if(Rand.Chance(chance*2))
                            {
                                sr.levelInt = temp;
                            }
                            break;
                        default:
                            if (Rand.Chance(chance))
                            {
                                sr.levelInt = temp;
                            }
                            break;
                    }
                }
            }
        }

        public override string ExtraTooltipPart()
        {
            string extra = "";
            Pawn p = parent.pawn;
            int skillLevel = p.skills.GetSkill(Props.skill ?? SkillDefOf.Intellectual).Level;
            float chance = Props.chancePerLevel * skillLevel;
            float minorChance = Mathf.Clamp(chance * 2, 0f, 1f);
            extra += "ESCP_SloadThrall_ExtraTooltip_ChanceSkillIncrease".Translate(minorChance.ToStringPercent(), chance.ToStringPercent());
            return extra;
        }
    }
}
