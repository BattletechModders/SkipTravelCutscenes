using BattleTech;
using Harmony;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

namespace SkipTravelCutscenes.Patches
{
    [HarmonyPatch(typeof(SGTravelManager), "BeginTransferAnim")]
    public static class SGTravelManager_BeginTransferAnim_Patch
    {
        public static void Postfix(SGTravelManager __instance)
        {
            __instance.AnimationInterrupt();
        }
    }
}
