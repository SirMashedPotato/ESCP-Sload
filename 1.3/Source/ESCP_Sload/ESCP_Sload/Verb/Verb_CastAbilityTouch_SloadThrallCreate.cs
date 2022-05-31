using System;
using Verse;
using RimWorld;
using ESCP_RaceTools;
using AlienRace;

namespace ESCP_Sload
{
    class Verb_CastAbilityTouch_SloadThrallCreate : Verb_CastAbilityTouch
    {
        public override bool ValidateTarget(LocalTargetInfo target, bool showMessages = true)
        {
            return base.ValidateTarget(target, showMessages) && IsValidCorpse(target.Thing);
        }

        public bool IsValidCorpse(Thing t)
        {
            if (t is Corpse c)
            {
                if (c.InnerPawn.def is AlienRace.ThingDef_AlienRace a && !a.alienRace.compatibility.IsFlesh)
                {
                    return false;
                }
                if (c.InnerPawn.RaceProps.IsFlesh && c.GetRotStage() == RotStage.Fresh
               && (ESCP_Sload_ModSettings.SloadThrallCanDryad || !c.InnerPawn.RaceProps.Dryad))
                {
                    var props = ESCP_RaceTools.RaceProperties.Get(c.InnerPawn.def);
                    if (props != null && props.sloadThrallImmune)
                    {
                        return false;
                    }
                    return true;
                }
            }

            return false;
        }

        public override bool IsUsableOn(Thing target)
        {
            return base.IsUsableOn(target) && IsValidCorpse(target);
        }
    }
}
