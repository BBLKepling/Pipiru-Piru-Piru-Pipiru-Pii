using HarmonyLib;
using Verse.Sound;
using Verse;

namespace PipiruPiruPiruPipiruPii
{
    public class ResurrectionUtilityPatches
    {
        [HarmonyPostfix]
        public static void Postfix(Pawn pawn, ref bool __result)
        {
            if (__result == true) InternalDefOf.BBLK_PipiruPiruPiruPipiruPii.PlayOneShot(new TargetInfo(pawn.Position, pawn.Map));
        }
    }
}
