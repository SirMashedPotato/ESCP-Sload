using System;
using Verse;
using RimWorld;

namespace ESCP_Sload
{
    class CompProperties_UseEffectThrassianElixir : CompProperties_UseEffectArtifact
    {
        public CompProperties_UseEffectThrassianElixir()
        {
            this.compClass = typeof(CompUseEffect_ThrassianElixir);
        }

        public HediffDef hediff;
    }
}
