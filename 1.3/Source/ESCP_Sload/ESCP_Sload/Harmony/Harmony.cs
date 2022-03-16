using HarmonyLib;
using System.Reflection;
using Verse;


namespace ESCP_Sload
{
    //Setting the Harmony instance
    [StaticConstructorOnStartup]
    public class Main
    {
        static Main()
        {
            var harmony = new Harmony("com.ESCP_Sload");
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            //conditional patches
            /*
            if (LoadedModManager.RunningModsListForReading.Any(x => x.PackageId == "pphhyy.Brachyura"))
            {
                harmony.Patch(AccessTools.Method(AccessTools.TypeByName("CrabMoulting"), "DoMoult"), prefix: new HarmonyMethod(typeof(DubsBadHygienePatches), nameof(NeedIntervalPrefix)));
                harmony.Patch(AccessTools.Method(AccessTools.TypeByName("CrabMoulting"), "CompInspectStringExtra"), prefix: new HarmonyMethod(typeof(DubsBadHygienePatches), nameof(NeedIntervalPrefix)));
            }
            */
        }
    }
}

