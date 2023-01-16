using Verse;

namespace ESCP_Sload
{
    class ESCP_Sload_ModSettings : ModSettings
    {
        private static ESCP_Sload_ModSettings _instance;

        /* ==========[GETTERS]========== */
        public static bool SloadThrassianPlagueIncident => _instance.ESCP_RaceTools_SloadThrassianPlagueIncident;
        public static bool LeatherThoughtSload => _instance.ESCP_RaceTools_LeatherThoughtSload;
        public static bool SloadThrassianFogAlert => _instance.ESCP_RaceTools_SloadThrassianFogAlert;
        public static bool SloadInspirations => _instance.ESCP_RaceTools_SloadInspirations;
        public static bool SloadCanEquipAllWeapons => _instance.ESCP_RaceTools_SloadCanEquipAllWeapons;

        //Sload thralls
        public static bool SloadThrallCanDryad => _instance.ESCP_RaceTools_SloadThrallCanDryad;
        public static bool SloadThrallResSkillDecay => _instance.ESCP_RaceTools_SloadThrallResSkillDecay;
        public static bool SloadThrallSkillLimit => _instance.ESCP_RaceTools_SloadThrallSkillLimit;

        public static bool SloadThrallDisableNeeds => _instance.ESCP_RaceTools_SloadThrallDisableNeeds;
        public static bool SloadThrallDisableMoods => _instance.ESCP_RaceTools_SloadThrallDisableMoods;
        public static bool SloadThrallIdeoCertainty => _instance.ESCP_RaceTools_SloadThrallIdeoCertainty;
        public static bool SloadThrallSkillLearning => _instance.ESCP_RaceTools_SloadThrallSkillLearning;
        public static bool SloadThrallSkillDecay => _instance.ESCP_RaceTools_SloadThrallSkillDecay;

        public static bool SloadThrallMilkable => _instance.ESCP_RaceTools_SloadThrallMilkable;
        public static bool SloadThrallShearable => _instance.ESCP_RaceTools_SloadThrallShearable;
        public static bool SloadThrallEggLaying => _instance.ESCP_RaceTools_SloadThrallEggLaying;
        public static bool SloadThrallTrainable => _instance.ESCP_RaceTools_SloadThrallTrainable;
        public static bool SloadThrallTrainableDecay => _instance.ESCP_RaceTools_SloadThrallTrainableDecay;
        public static bool SloadThrallMating => _instance.ESCP_RaceTools_SloadThrallMating;
        public static bool SloadThrallInspirations => _instance.ESCP_RaceTools_SloadThrallInspirations;

        public static bool SloadThrallDisableBloodloss => _instance.ESCP_RaceTools_SloadThrallDisableBloodloss;
        public static bool SloadThrallDisableHeatstroke => _instance.ESCP_RaceTools_SloadThrallDisableHeatstroke;
        public static bool SloadThrallDisableHypothermia => _instance.ESCP_RaceTools_SloadThrallDisableHypothermia;

        public static bool SloadThrallDisableSocialInteractions => _instance.ESCP_RaceTools_SloadThrallSocialInteractions;

        public static bool SloadThrallVEF_AnimalProducts => _instance.ESCP_RaceTools_SloadThrallVEF_AnimalProducts;
        public static bool SloadThrallVEF_AsexualReproduction => _instance.ESCP_RaceTools_SloadThrallVEF_AsexualReproduction;

        public static bool SloadThrallNamesArePurple => _instance.ESCP_RaceTools_SloadThrallNamesArePurple;
        public static bool SloadThrallNamesColourTranspilerA => _instance.ESCP_RaceTools_SloadThrallNamesColourTranspilerA;
        public static bool SloadThrallNamesColourTranspilerB => _instance.ESCP_RaceTools_SloadThrallNamesColourTranspilerB;

        /* ==========[VARIABLES]========== */
        public bool ESCP_RaceTools_SloadThrassianPlagueIncident = ESCP_RaceTools_SloadThrassianPlagueIncident_def;
        public bool ESCP_RaceTools_LeatherThoughtSload = ESCP_RaceTools_LeatherThoughtSload_def;
        public bool ESCP_RaceTools_SloadThrassianFogAlert = ESCP_RaceTools_SloadThrassianFogAlert_def;
        public bool ESCP_RaceTools_SloadInspirations = ESCP_RaceTools_SloadInspirations_def;
        public bool ESCP_RaceTools_SloadCanEquipAllWeapons = ESCP_RaceTools_SloadCanEquipAllWeapons_def;

        //Sload thralls
        public bool ESCP_RaceTools_SloadThrallCanDryad = ESCP_RaceTools_SloadThrallCanDryad_def;
        public bool ESCP_RaceTools_SloadThrallResSkillDecay = ESCP_RaceTools_SloadThrallResSkillDecay_def;
        public bool ESCP_RaceTools_SloadThrallSkillLimit = ESCP_RaceTools_SloadThrallSkillLimit_def;

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
        public bool ESCP_RaceTools_SloadThrallInspirations = ESCP_RaceTools_SloadThrallInspirations_def;

        public bool ESCP_RaceTools_SloadThrallDisableBloodloss = ESCP_RaceTools_SloadThrallDisableBloodloss_def;
        public bool ESCP_RaceTools_SloadThrallDisableHeatstroke = ESCP_RaceTools_SloadThrallDisableHeatstroke_def;
        public bool ESCP_RaceTools_SloadThrallDisableHypothermia = ESCP_RaceTools_SloadThrallDisableHypothermia_def;

        public bool ESCP_RaceTools_SloadThrallSocialInteractions = ESCP_RaceTools_SloadThrallSocialInteractions_def;

        public bool ESCP_RaceTools_SloadThrallVEF_AnimalProducts = ESCP_RaceTools_SloadThrallVEF_AnimalProducts_def;
        public bool ESCP_RaceTools_SloadThrallVEF_AsexualReproduction = ESCP_RaceTools_SloadThrallVEF_AsexualReproduction_def;

        public bool ESCP_RaceTools_SloadThrallNamesArePurple = ESCP_RaceTools_SloadThrallNamesArePurple_def;
        public bool ESCP_RaceTools_SloadThrallNamesColourTranspilerA = ESCP_RaceTools_SloadThrallNamesColourTranspilerA_def;
        public bool ESCP_RaceTools_SloadThrallNamesColourTranspilerB = ESCP_RaceTools_SloadThrallNamesColourTranspilerB_def;

        /* ==========[DEFAULTS]========== */
        private static readonly bool ESCP_RaceTools_SloadThrassianPlagueIncident_def = true;
        private static readonly bool ESCP_RaceTools_LeatherThoughtSload_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrassianFogAlert_def = true;
        private static readonly bool ESCP_RaceTools_SloadInspirations_def = true;
        private static readonly bool ESCP_RaceTools_SloadCanEquipAllWeapons_def = true;

        //Sload thralls
        private static readonly bool ESCP_RaceTools_SloadThrallCanDryad_def = false;
        private static readonly bool ESCP_RaceTools_SloadThrallResSkillDecay_def = false;
        private static readonly bool ESCP_RaceTools_SloadThrallSkillLimit_def = false;

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
        private static readonly bool ESCP_RaceTools_SloadThrallInspirations_def = true;

        private static readonly bool ESCP_RaceTools_SloadThrallDisableBloodloss_def = false;
        private static readonly bool ESCP_RaceTools_SloadThrallDisableHeatstroke_def = false;
        private static readonly bool ESCP_RaceTools_SloadThrallDisableHypothermia_def = false;

        private static readonly bool ESCP_RaceTools_SloadThrallSocialInteractions_def = true;

        private static readonly bool ESCP_RaceTools_SloadThrallVEF_AnimalProducts_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallVEF_AsexualReproduction_def = true;

        private static readonly bool ESCP_RaceTools_SloadThrallNamesArePurple_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallNamesColourTranspilerA_def = true;
        private static readonly bool ESCP_RaceTools_SloadThrallNamesColourTranspilerB_def = true;

        public ESCP_Sload_ModSettings()
        {
            _instance = this;
        }

        /* ==========[SAVING]========== */
        public override void ExposeData()
        {
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrassianPlagueIncident, "ESCP_RaceTools_SloadThrassianPlagueIncident", ESCP_RaceTools_SloadThrassianPlagueIncident_def);
            Scribe_Values.Look(ref ESCP_RaceTools_LeatherThoughtSload, "ESCP_RaceTools_LeatherThoughtSload", ESCP_RaceTools_LeatherThoughtSload_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrassianFogAlert, "ESCP_RaceTools_SloadThrassianFogAlert", ESCP_RaceTools_SloadThrassianFogAlert_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadInspirations, "ESCP_RaceTools_SloadInspirations", ESCP_RaceTools_SloadInspirations_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadCanEquipAllWeapons, "ESCP_RaceTools_SloadCanEquipAllWeapons", ESCP_RaceTools_SloadCanEquipAllWeapons_def);

            //Sload thralls
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallCanDryad, "ESCP_RaceTools_SloadThrallCanDryad", ESCP_RaceTools_SloadThrallCanDryad_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallResSkillDecay, "ESCP_RaceTools_SloadThrallResSkillDecay", ESCP_RaceTools_SloadThrallResSkillDecay_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallSkillLimit, "ESCP_RaceTools_SloadThrallSkillLimit", ESCP_RaceTools_SloadThrallSkillLimit_def);

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
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallInspirations, "ESCP_RaceTools_SloadThrallInspirations", ESCP_RaceTools_SloadThrallInspirations_def);

            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallDisableBloodloss, "ESCP_RaceTools_SloadThrallDisableBloodloss", ESCP_RaceTools_SloadThrallDisableBloodloss_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallDisableHeatstroke, "ESCP_RaceTools_SloadThrallDisableHeatstroke", ESCP_RaceTools_SloadThrallDisableHeatstroke_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallDisableHypothermia, "ESCP_RaceTools_SloadThrallDisableHypothermia", ESCP_RaceTools_SloadThrallDisableHypothermia_def);

            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallSocialInteractions, "ESCP_RaceTools_SloadThrallSocialInteractions", ESCP_RaceTools_SloadThrallSocialInteractions_def);

            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallVEF_AnimalProducts, "ESCP_RaceTools_SloadThrallVEF_AnimalProducts", ESCP_RaceTools_SloadThrallVEF_AnimalProducts_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallVEF_AsexualReproduction, "ESCP_RaceTools_SloadThrallVEF_AsexualReproduction", ESCP_RaceTools_SloadThrallVEF_AsexualReproduction_def);

            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallNamesArePurple, "ESCP_RaceTools_SloadThrallNamesArePurple", ESCP_RaceTools_SloadThrallNamesArePurple_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallNamesColourTranspilerA, "ESCP_RaceTools_SloadThrallNamesColourTranspilerA", ESCP_RaceTools_SloadThrallNamesColourTranspilerA_def);
            Scribe_Values.Look(ref ESCP_RaceTools_SloadThrallNamesColourTranspilerB, "ESCP_RaceTools_SloadThrallNamesColourTranspilerB", ESCP_RaceTools_SloadThrallNamesColourTranspilerB_def);

            base.ExposeData();
        }

        /* ==========[Resetting]========== */
        public static void ResetSettings()
        {
            ResetSettings_General();
            ResetSettings_Thrall();
        }

        public static void ResetSettings_General()
        {
            _instance.ESCP_RaceTools_SloadThrassianPlagueIncident = ESCP_RaceTools_SloadThrassianPlagueIncident_def;
            _instance.ESCP_RaceTools_LeatherThoughtSload = ESCP_RaceTools_LeatherThoughtSload_def;
            _instance.ESCP_RaceTools_SloadThrassianFogAlert = ESCP_RaceTools_SloadThrassianFogAlert_def;
            _instance.ESCP_RaceTools_SloadInspirations = ESCP_RaceTools_SloadInspirations_def;
            _instance.ESCP_RaceTools_SloadCanEquipAllWeapons = ESCP_RaceTools_SloadCanEquipAllWeapons_def;
        }

        public static void ResetSettings_Thrall()
        {
            _instance.ESCP_RaceTools_SloadThrallCanDryad = ESCP_RaceTools_SloadThrallCanDryad_def;
            _instance.ESCP_RaceTools_SloadThrallResSkillDecay = ESCP_RaceTools_SloadThrallResSkillDecay_def;
            _instance.ESCP_RaceTools_SloadThrallSkillLimit = ESCP_RaceTools_SloadThrallSkillLimit_def;

            _instance.ESCP_RaceTools_SloadThrallDisableNeeds = ESCP_RaceTools_SloadThrallDisableNeeds_def;
            _instance.ESCP_RaceTools_SloadThrallDisableMoods = ESCP_RaceTools_SloadThrallDisableMoods_def;
            _instance.ESCP_RaceTools_SloadThrallIdeoCertainty = ESCP_RaceTools_SloadThrallIdeoCertainty_def;
            _instance.ESCP_RaceTools_SloadThrallSkillLearning = ESCP_RaceTools_SloadThrallSkillLearning_def;
            _instance.ESCP_RaceTools_SloadThrallSkillDecay = ESCP_RaceTools_SloadThrallSkillDecay_def;

            _instance.ESCP_RaceTools_SloadThrallMilkable = ESCP_RaceTools_SloadThrallMilkable_def;
            _instance.ESCP_RaceTools_SloadThrallShearable = ESCP_RaceTools_SloadThrallShearable_def;
            _instance.ESCP_RaceTools_SloadThrallEggLaying = ESCP_RaceTools_SloadThrallEggLaying_def;
            _instance.ESCP_RaceTools_SloadThrallTrainable = ESCP_RaceTools_SloadThrallTrainable_def;
            _instance.ESCP_RaceTools_SloadThrallTrainableDecay = ESCP_RaceTools_SloadThrallTrainableDecay_def;
            _instance.ESCP_RaceTools_SloadThrallMating = ESCP_RaceTools_SloadThrallMating_def;
            _instance.ESCP_RaceTools_SloadThrallInspirations = ESCP_RaceTools_SloadThrallInspirations_def;

            _instance.ESCP_RaceTools_SloadThrallVEF_AnimalProducts = ESCP_RaceTools_SloadThrallVEF_AnimalProducts_def;
            _instance.ESCP_RaceTools_SloadThrallVEF_AsexualReproduction = ESCP_RaceTools_SloadThrallVEF_AsexualReproduction_def;

            _instance.ESCP_RaceTools_SloadThrallDisableBloodloss = ESCP_RaceTools_SloadThrallDisableBloodloss_def;
            _instance.ESCP_RaceTools_SloadThrallDisableHeatstroke = ESCP_RaceTools_SloadThrallDisableHeatstroke_def;
            _instance.ESCP_RaceTools_SloadThrallDisableHypothermia = ESCP_RaceTools_SloadThrallDisableHypothermia_def;

            _instance.ESCP_RaceTools_SloadThrallSocialInteractions = ESCP_RaceTools_SloadThrallSocialInteractions_def;

            _instance.ESCP_RaceTools_SloadThrallNamesArePurple = ESCP_RaceTools_SloadThrallNamesArePurple_def;
            _instance.ESCP_RaceTools_SloadThrallNamesColourTranspilerA = ESCP_RaceTools_SloadThrallNamesColourTranspilerA_def;
            _instance.ESCP_RaceTools_SloadThrallNamesColourTranspilerB = ESCP_RaceTools_SloadThrallNamesColourTranspilerB_def;
        }
    }
}
