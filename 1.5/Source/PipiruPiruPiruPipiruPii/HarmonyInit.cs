using HarmonyLib;
using RimWorld;
using Verse;

namespace PipiruPiruPiruPipiruPii
{
    [StaticConstructorOnStartup]
    public static class HarmonyInit
    {
        static HarmonyInit()
        {
            Harmony harmonyInstance = new Harmony("BBLKepling.PipiruPiruPiruPipiruPii");
            harmonyInstance.Patch(typeof(ResurrectionUtility).GetMethod("TryResurrect"), postfix: new HarmonyMethod(typeof(ResurrectionUtilityPatches).GetMethod("Postfix")));
            harmonyInstance.Patch(typeof(ResurrectionUtility).GetMethod("TryResurrectWithSideEffects"), postfix: new HarmonyMethod(typeof(ResurrectionUtilityPatches).GetMethod("Postfix")));
        }
    }
}
