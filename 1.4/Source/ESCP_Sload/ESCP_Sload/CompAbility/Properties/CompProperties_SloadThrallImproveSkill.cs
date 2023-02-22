using RimWorld;

namespace ESCP_Sload
{
    class CompProperties_SloadThrallImproveSkill : CompProperties_AbilityEffect
    {
        public CompProperties_SloadThrallImproveSkill()
        {
            compClass = typeof(CompAbilityEffect_SloadThrallImproveSkill);
        }

        public SkillDef skill;
        public int improvement = 1;
        public float chancePerLevel = 0.05f;
    }
}
