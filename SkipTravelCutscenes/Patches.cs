using BattleTech;
using Harmony;
using System.Reflection;

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

    public static class Patches
    {
        public static void Init(string modDir, string modSettings)
        {
            var harmony = HarmonyInstance.Create("io.github.mpstark.SkipTravelCutscenes");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
