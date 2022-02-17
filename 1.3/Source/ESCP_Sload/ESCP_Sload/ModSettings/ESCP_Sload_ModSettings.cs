using Verse;

namespace ESCP_Sload
{
    class ESCP_Sload_ModSettings : ModSettings
    {
        public bool ESCP_RaceTools_SloadThrassianPlagueIncident = ESCP_RaceTools_SloadThrassianPlagueIncident_def;
        public bool ESCP_RaceTools_LeatherThoughtSload = ESCP_RaceTools_LeatherThoughtSload_def;

        //Sload thralls
        public bool ESCP_RaceTools_SloadThrallDisableNeeds = ESCP_RaceTools_SloadThrallDisableNeeds_def;
        public bool ESCP_RaceTools_SloadThrallDisableMoods = ESCP_RaceTools_SloadThrallDisableMoods_def;
        public bool ESCP_RaceTools_SloadThrallIdeoCertainty = ESCP_RaceTools_SloadThrallIdeoCertainty_def;
        public bool ESCP_RaceTools_SloadThrallSkillLearning = ESCP_RaceTools_SloadThrallSkillLearning_def;
        public bool ESCP_RaceTools_SloadThrallSkillDecay = ESCP_RaceTools_SloadThrallSkillDecay_def;

        public bool ESCP_RaceTools_SloadThrallMilkable = ESCP_RaceTools_SloadThrallMilkable_def;
        public bool ESCP_RaceTools_SloadThrallShearable = ESCP_RaceTools_SloadThrallShearable_def;
        public bool ESCP_RaceTools_SloadThrallEggLaying = ESCP_RaceTools_SloadThrallEggLaying_def;
        public bool ESCP_RaceTools_SloadThrallTrainable = ESCP_RaceTools_SloadThrallTrainable_def;
        public bool ESCP_RaceTools_SloadThrallTrainableDecay = ESCP_RaceTools_SloadThrallTrainableDecay_def;
        public bool ESCP_RaceTools_SloadThrallMating = ESCP_RaceTools_SloadThrallMating_def;

        public bool ESCP_RaceTools_SloadThrallNamesArePurple = ESCP_RaceTools_SloadThrallNamesArePurple_def;
        public bool ESCP_RaceTools_SloadThrallNamesColourTranspilerA = ESCP_RaceTools_SloadThrallNamesColourTranspilerA_def;
        public bool ESCP_RaceTools_SloadThrallNamesColourTranspilerB = ESCP_RaceTools_SloadThrallNamesColourTranspilerB_def;

        //Defaults

        private static readonly bool ESCP_RaceTools_SloadThrassianPlagueIncident_def = true;
        private static readonly bool ESCP_RaceTools_LeatherThoughtSload_def = true;

        //Sload thralls
        private static readonly bool ESCP_RaceTools_SloadThrallDisableNeeds_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallDisableMoods_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallIdeoCertainty_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallSkillLearning_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallSkillDecay_def = true;

        private static readonly bool ESCP_RaceTools_SloadThrallMilkable_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallShearable_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallEggLaying_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallTrainable_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallTrainableDecay_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallMating_def = true;

        private static readonly bool ESCP_RaceTools_SloadThrallNamesArePurple_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallNamesColourTranspilerA_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallNamesColourTranspilerB_def = true;



        //save settings
        public override void ExposeData()
        {
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrassianPlagueIncident, "ESCP_RaceTools_SloadThrassianPlagueIncident", ESCP_RaceTools_SloadThrassianPlagueIncident_def);
            Scribe_Values.Look(ref ESCP_RaceTools_LeatherThoughtSload, "ESCP_RaceTools_LeatherThoughtSload", ESCP_RaceTools_LeatherThoughtSload_def);

            //Sload thralls
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallDisableNeeds, "ESCP_RaceTools_SloadThrallDisableNeeds", ESCP_RaceTools_SloadThrallDisableNeeds_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallDisableMoods, "ESCP_RaceTools_SloadThrallDisableMoods", ESCP_RaceTools_SloadThrallDisableMoods_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallIdeoCertainty, "ESCP_RaceTools_SloadThrallIdeoCertainty", ESCP_RaceTools_SloadThrallIdeoCertainty_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallSkillLearning, "ESCP_RaceTools_SloadThrallSkillLearning", ESCP_RaceTools_SloadThrallSkillLearning_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallSkillDecay, "ESCP_RaceTools_SloadThrallSkillDecay", ESCP_RaceTools_SloadThrallSkillDecay_def);

            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallMilkable, "ESCP_RaceTools_SloadThrallMilkable", ESCP_RaceTools_SloadThrallMilkable_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallShearable, "ESCP_RaceTools_SloadThrallShearable", ESCP_RaceTools_SloadThrallShearable_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallEggLaying, "ESCP_RaceTools_SloadThrallEggLaying", ESCP_RaceTools_SloadThrallEggLaying_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallTrainable, "ESCP_RaceTools_SloadThrallTrainable", ESCP_RaceTools_SloadThrallTrainable_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallTrainableDecay, "ESCP_RaceTools_SloadThrallTrainableDecay", ESCP_RaceTools_SloadThrallTrainableDecay_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallMating, "ESCP_RaceTools_SloadThrallMating", ESCP_RaceTools_SloadThrallMating_def);

            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallNamesArePurple, "ESCP_RaceTools_SloadThrallNamesArePurple", ESCP_RaceTools_SloadThrallNamesArePurple_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallNamesColourTranspilerA, "ESCP_RaceTools_SloadThrallNamesColourTranspilerA", ESCP_RaceTools_SloadThrallNamesColourTranspilerA_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallNamesColourTranspilerB, "ESCP_RaceTools_SloadThrallNamesColourTranspilerB", ESCP_RaceTools_SloadThrallNamesColourTranspilerB_def);

            base.ExposeData();
        }

        //rest settings
        public static void ResetSettings(ESCP_Sload_ModSettings settings)
        {
            ResetSettings_General(settings);
            ResetSettings_Thrall(settings);
        }

        public static void ResetSettings_General(ESCP_Sload_ModSettings settings)
        {
            settings.ESCP_RaceTools_SloadThrassianPlagueIncident = ESCP_RaceTools_SloadThrassianPlagueIncident_def;
            settings.ESCP_RaceTools_LeatherThoughtSload = ESCP_RaceTools_LeatherThoughtSload_def;
        }

        public static void ResetSettings_Thrall(ESCP_Sload_ModSettings settings)
        {
            settings.ESCP_RaceTools_SloadThrallDisableNeeds = ESCP_RaceTools_SloadThrallDisableNeeds_def;
            settings.ESCP_RaceTools_SloadThrallDisableMoods = ESCP_RaceTools_SloadThrallDisableMoods_def;
            settings.ESCP_RaceTools_SloadThrallIdeoCertainty = ESCP_RaceTools_SloadThrallIdeoCertainty_def;
            settings.ESCP_RaceTools_SloadThrallSkillLearning = ESCP_RaceTools_SloadThrallSkillLearning_def;
            settings.ESCP_RaceTools_SloadThrallSkillDecay = ESCP_RaceTools_SloadThrallSkillDecay_def;

            settings.ESCP_RaceTools_SloadThrallMilkable = ESCP_RaceTools_SloadThrallMilkable_def;
            settings.ESCP_RaceTools_SloadThrallShearable = ESCP_RaceTools_SloadThrallShearable_def;
            settings.ESCP_RaceTools_SloadThrallEggLaying = ESCP_RaceTools_SloadThrallEggLaying_def;
            settings.ESCP_RaceTools_SloadThrallTrainable = ESCP_RaceTools_SloadThrallTrainable_def;
            settings.ESCP_RaceTools_SloadThrallTrainableDecay = ESCP_RaceTools_SloadThrallTrainableDecay_def;
            settings.ESCP_RaceTools_SloadThrallMating = ESCP_RaceTools_SloadThrallMating_def;

            settings.ESCP_RaceTools_SloadThrallNamesArePurple = ESCP_RaceTools_SloadThrallNamesArePurple_def;
            settings.ESCP_RaceTools_SloadThrallNamesColourTranspilerA = ESCP_RaceTools_SloadThrallNamesColourTranspilerA_def;
            settings.ESCP_RaceTools_SloadThrallNamesColourTranspilerB = ESCP_RaceTools_SloadThrallNamesColourTranspilerB_def;
        }
    }
}
