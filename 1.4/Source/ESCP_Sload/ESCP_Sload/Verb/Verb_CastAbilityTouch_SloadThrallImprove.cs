using Verse;
using RimWorld;

namespace ESCP_Sload
{
    class Verb_CastAbilityTouch_SloadThrallImprove : Verb_CastAbilityTouch
    {
        public override bool ValidateTarget(LocalTargetInfo target, bool showMessages = true)
        {
            return base.ValidateTarget(target, showMessages) && IsValidPawn(target.Thing);
        }

        public bool IsValidPawn(Thing t)
        {
            return t is Pawn p && SloadUtility.PawnIsThrall(p) && this.Caster.TryGetComp<Comp_SloadThralls>().thralls.Contains(p);
        }

        public override bool IsUsableOn(Thing target)
        {
            return base.IsUsableOn(target) && IsValidPawn(target);
        }
    }
}
