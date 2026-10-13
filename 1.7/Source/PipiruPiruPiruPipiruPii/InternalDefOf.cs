using RimWorld;
using Verse;

namespace PipiruPiruPiruPipiruPii
{
    [DefOf]
    public static class InternalDefOf
    {
        static InternalDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(InternalDefOf));
        }

        public static SoundDef BBLK_PipiruPiruPiruPipiruPii;
    }
}
