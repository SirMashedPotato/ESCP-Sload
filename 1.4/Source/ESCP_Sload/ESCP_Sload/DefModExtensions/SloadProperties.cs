using Verse;
using RimWorld;

namespace ESCP_Sload
{
    public class SloadProperties : DefModExtension
    {
        //For thing defs
        public AbilityDef startingAbilityDef;
        //For thing defs
        public HistoryEventDef eventOnDeath;
        //For thing defs, designates if they are a immune to becoming a thrall
        public bool sloadThrallImmune = false;
        //For thing defs, designates if they are a immune to being infected by the thrassian plague
        public bool thrassianPlagueImmune = false;
        //For faction defs, designates if they are a sload faction
        public bool isSloadFaction = false;

        public static SloadProperties Get(Def def)
        {
            return def.GetModExtension<SloadProperties>();
        }
    }
}
