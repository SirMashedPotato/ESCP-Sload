using Verse;
using RimWorld;

namespace ESCP_Sload
{
    class CompAbilityEffect_ReleaseThrassianFog : CompAbilityEffect
    {
        public new CompProperties_ReleaseThrassianFog Props
        {
            get
            {
                return (CompProperties_ReleaseThrassianFog)props;
            }
        }

		public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
        {
            parent.pawn.Map.GetComponent<MapComp_ThrassianMiasma>().IncreaseDays(Props.days);
            Messages.Message("ESCP_Sload_Message_ThrassianFog".Translate(Props.days), null, MessageTypeDefOf.PositiveEvent, true);
        }
    }
}
