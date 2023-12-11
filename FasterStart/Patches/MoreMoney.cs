using HarmonyLib;
namespace MoreMoneyStart.Patches
{
    [HarmonyPatch(typeof(TimeOfDay))]
    [HarmonyPatch("Awake")]
    public static class TimeOfDayAwakePatch
    {
        static void Postfix(TimeOfDay __instance)
        {
            if (__instance.quotaVariables != null)
            {
                __instance.quotaVariables.startingCredits = MoreMoneyStart.Instance.startingAmount.Value;
            }
        }
    }
}