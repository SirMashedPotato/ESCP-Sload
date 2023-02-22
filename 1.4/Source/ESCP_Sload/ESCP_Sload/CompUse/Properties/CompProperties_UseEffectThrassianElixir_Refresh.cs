using RimWorld;

namespace ESCP_Sload
{
    class CompProperties_UseEffectThrassianElixir_Refresh : CompProperties_UseEffectArtifact
    {
        public CompProperties_UseEffectThrassianElixir_Refresh()
        {
            compClass = typeof(CompUseEffect_ThrassianElixir_Refresh);
        }

        public AbilityDef ability;
    }
}
