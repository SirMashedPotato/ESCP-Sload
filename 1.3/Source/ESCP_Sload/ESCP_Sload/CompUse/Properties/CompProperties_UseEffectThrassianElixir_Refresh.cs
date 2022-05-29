using System;
using Verse;
using RimWorld;

namespace ESCP_Sload
{
    class CompProperties_UseEffectThrassianElixir_Refresh : CompProperties_UseEffectArtifact
    {
        public CompProperties_UseEffectThrassianElixir_Refresh()
        {
            this.compClass = typeof(CompUseEffect_ThrassianElixir_Refresh);
        }

        public AbilityDef ability;
    }
}
