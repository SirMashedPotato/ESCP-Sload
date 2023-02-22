using RimWorld;

namespace ESCP_Sload
{
    class CompProperties_ReleaseThrassianFog : CompProperties_AbilityEffect
    {
        public CompProperties_ReleaseThrassianFog()
        {
            compClass = typeof(CompAbilityEffect_ReleaseThrassianFog);
        }

        public int days = 5;
    }
}
