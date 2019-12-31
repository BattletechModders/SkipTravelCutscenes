using BattleTech;
using Harmony;
using UnityEngine;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

namespace SkipTravelCutscenes.Patches
{
    [HarmonyPatch(typeof(SimGameSpaceController), "JumpDrive")]
    public static class SimGameSpaceController_JumpDrive_Patch
    {
        public static bool Prefix(SimGameSpaceController __instance)
        {
            __instance.TransitionEnd(null, new AnimatorStateInfo());
            return false;
        }
    }
}
