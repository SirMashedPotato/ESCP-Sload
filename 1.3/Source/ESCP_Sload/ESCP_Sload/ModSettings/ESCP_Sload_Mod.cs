using UnityEngine;
using Verse;
using System;

namespace ESCP_Sload
{
    class ESCP_Sload_Mod : Mod
    {
        ESCP_Sload_ModSettings settings;
        public ESCP_Sload_Mod(ModContentPack contentPack) : base(contentPack)
        {
            this.settings = GetSettings<ESCP_Sload_ModSettings>();
        }

        public override string SettingsCategory() => "ESCP_Sload_ModName".Translate();

        private int page = 0;

        private static Vector2 scrollPosition = Vector2.zero;

        public override void DoSettingsWindowContents(Rect inRect)
        {

            var firstColumnWidth = (inRect.width - Listing.ColumnSpacing) * 3.5f / 5f;
            var secondColumnWidth = inRect.width - Listing.ColumnSpacing - firstColumnWidth;

            var outerRect = new Rect(inRect.x, inRect.y, firstColumnWidth, inRect.height);
            var innerRect = new Rect(0f, 0f, firstColumnWidth - 24f, inRect.height * 2);
            Widgets.BeginScrollView(outerRect, ref scrollPosition, innerRect, true);

            var listing_Standard = new Listing_Standard();
            listing_Standard.Begin(innerRect);

            //get page
            switch (page)
            {
                case 0:
                    listing_Standard = SettingsPage_General(listing_Standard);
                    break;
                case 1:
                    listing_Standard = SettingsPage_Thrall(listing_Standard);
                    break;

                default:
                    listing_Standard = SettingsPage_General(listing_Standard);
                    break;
            }

            listing_Standard.End();
            Widgets.EndScrollView();
            base.DoSettingsWindowContents(inRect);

            //buttons pane
            outerRect.x += firstColumnWidth + Listing.ColumnSpacing;
            outerRect.width = secondColumnWidth;

            listing_Standard = new Listing_Standard();
            listing_Standard.Begin(outerRect);
            SettingsButtons(listing_Standard);
            listing_Standard.End();
        }

        private Listing_Standard SettingsButtons(Listing_Standard listing_Standard)
        {
            listing_Standard.Gap();

            Rect rectPageDefault = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPageDefault, "ESCP_PageGeneral".Translate());
            if (Widgets.ButtonText(rectPageDefault, "ESCP_PageGeneral".Translate(), true, true, true))
            {
                page = 0;
            }
            listing_Standard.Gap();

            Rect rectPageThrall = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPageThrall, "ESCP_PageSloadThralls".Translate());
            if (Widgets.ButtonText(rectPageThrall, "ESCP_PageSloadThralls".Translate(), true, true, true))
            {
                page = 1;
            }
            listing_Standard.Gap();

            listing_Standard.GapLine();

            //reset
            Rect rectDefault = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectDefault, "ESCP_Reset".Translate());
            if (Widgets.ButtonText(rectDefault, "ESCP_Reset".Translate(), true, true, true))
            {
                ESCP_Sload_ModSettings.ResetSettings(settings);
            }
            listing_Standard.Gap();
            ResetButtonForPage(listing_Standard);

            return listing_Standard;
        }

        private void ResetButtonForPage(Listing_Standard listing_Standard)
        {
            Rect rectDefault = listing_Standard.GetRect(30f);
            switch (page)
            {
                case 0:
                    listing_Standard.Gap();
                    TooltipHandler.TipRegion(rectDefault, "ESCP_PageGeneralReset".Translate());
                    if (Widgets.ButtonText(rectDefault, "ESCP_PageGeneralReset".Translate(), true, true, true))
                    {
                        ESCP_Sload_ModSettings.ResetSettings_General(settings);
                    }
                    break;

                case 1:
                    listing_Standard.Gap();
                    TooltipHandler.TipRegion(rectDefault, "ESCP_PageSloadThrallsReset".Translate());
                    if (Widgets.ButtonText(rectDefault, "ESCP_PageSloadThrallsReset".Translate(), true, true, true))
                    {
                        ESCP_Sload_ModSettings.ResetSettings_Thrall(settings);
                    }
                    break;

                default:
                    break;
            }
        }

        /* specific pages */

        private Listing_Standard SettingsPage_General(Listing_Standard listing_Standard)
        {
            listing_Standard.Label("ESCP_PageGeneral".Translate());
            listing_Standard.GapLine();
            listing_Standard.Gap();

            //settings

            listing_Standard.CheckboxLabeled("ESCP_RaceTools_LeatherThought".Translate(ThingDefOf.ESCP_LeatherSload.label), ref settings.ESCP_RaceTools_LeatherThoughtSload);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("ESCP_RaceTools_SloadThrassianPlagueIncident".Translate(), ref settings.ESCP_RaceTools_SloadThrassianPlagueIncident, "ESCP_RaceTools_SloadThrassianPlagueIncidentTooltip".Translate());
            listing_Standard.Gap();

            listing_Standard.GapLine();
            listing_Standard.Gap();

            return listing_Standard;
        }

        private Listing_Standard SettingsPage_Thrall(Listing_Standard listing_Standard)
        {
            listing_Standard.Label("ESCP_PageSloadThralls".Translate());
            listing_Standard.GapLine();
            listing_Standard.Gap();

            //settings

            listing_Standard.CheckboxLabeled("ESCP_RaceTools_SloadThrallNamesArePurple".Translate(), ref settings.ESCP_RaceTools_SloadThrallNamesArePurple, "ESCP_RaceTools_SloadThrallNamesArePurple_Tooltip".Translate());
            listing_Standard.Gap();

            listing_Standard.GapLine();
            listing_Standard.Gap();

            //Disables
            listing_Standard.CheckboxLabeled("ESCP_RaceTools_SloadThrallDisableNeeds".Translate(), ref settings.ESCP_RaceTools_SloadThrallDisableNeeds);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("ESCP_RaceTools_SloadThrallDisableMoods".Translate(), ref settings.ESCP_RaceTools_SloadThrallDisableMoods);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("ESCP_RaceTools_SloadThrallIdeoCertainty".Translate(), ref settings.ESCP_RaceTools_SloadThrallIdeoCertainty);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("ESCP_RaceTools_SloadThrallSkillLearning".Translate(), ref settings.ESCP_RaceTools_SloadThrallSkillLearning);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("ESCP_RaceTools_SloadThrallSkillDecay".Translate(), ref settings.ESCP_RaceTools_SloadThrallSkillDecay);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("ESCP_RaceTools_SloadThrallTrainable".Translate(), ref settings.ESCP_RaceTools_SloadThrallTrainable);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("ESCP_RaceTools_SloadThrallTrainableDecay".Translate(), ref settings.ESCP_RaceTools_SloadThrallTrainableDecay);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("ESCP_RaceTools_SloadThrallMilkable".Translate(), ref settings.ESCP_RaceTools_SloadThrallMilkable);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("ESCP_RaceTools_SloadThrallShearable".Translate(), ref settings.ESCP_RaceTools_SloadThrallShearable);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("ESCP_RaceTools_SloadThrallEggLaying".Translate(), ref settings.ESCP_RaceTools_SloadThrallEggLaying);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("ESCP_RaceTools_SloadThrallMating".Translate(), ref settings.ESCP_RaceTools_SloadThrallMating);
            listing_Standard.Gap();

            listing_Standard.GapLine();
            listing_Standard.Gap();

            return listing_Standard;
        }
    }
}
