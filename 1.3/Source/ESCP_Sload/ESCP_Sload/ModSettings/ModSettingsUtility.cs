using Verse;

namespace ESCP_Sload
{
    public class ModSettingsUtility
    {

        public static bool ESCP_RaceTools_LeatherThoughtSload()
        {
            return LoadedModManager.GetMod<ESCP_Sload_Mod>().GetSettings<ESCP_Sload_ModSettings>().ESCP_RaceTools_LeatherThoughtSload;
        }

        public static bool ESCP_RaceTools_SloadThrassianPlagueIncident()
        {
            return LoadedModManager.GetMod<ESCP_Sload_Mod>().GetSettings<ESCP_Sload_ModSettings>().ESCP_RaceTools_SloadThrassianPlagueIncident;
        }

        public static bool ESCP_RaceTools_SloadThrassianFogAlert()
        {
            return LoadedModManager.GetMod<ESCP_Sload_Mod>().GetSettings<ESCP_Sload_ModSettings>().ESCP_RaceTools_SloadThrassianFogAlert;
        }

        public static bool ESCP_RaceTools_SloadInspirations()
        {
            return LoadedModManager.GetMod<ESCP_Sload_Mod>().GetSettings<ESCP_Sload_ModSettings>().ESCP_RaceTools_SloadInspirations;
        }

        public static bool ESCP_RaceTools_SloadCanEquipAllWeapons()
        {
            return LoadedModManager.GetMod<ESCP_Sload_Mod>().GetSettings<ESCP_Sload_ModSettings>().ESCP_RaceTools_SloadCanEquipAllWeapons;
        }
    }
}
