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

    [HarmonyPatch(typeof(SGTravelManager), "ReturnFromTransferAnim")]
    public static class SGTravelManager_ReturnFromTransferAnim_Patch
    {
        public static void Postfix(SGTravelManager __instance)
        {
            var animCounter = Traverse.Create(__instance).Field("jumpshipChargeAndLeaveAnimCounter").GetValue<int>();
            if (animCounter == 1)
                __instance.AnimationInterrupt();
        }
    }
}
