using BattleTech;
using Harmony;

namespace SkipTravelCutscenes
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
