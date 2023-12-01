using HarmonyLib;
namespace MoreMoneyStart.Patches
{
    [HarmonyPatch(typeof(Terminal))]
    internal class MoreMoney
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        static void betterStartingAmount(ref int ___groupCredits)
        {
            if (___groupCredits == TimeOfDay.Instance.quotaVariables.startingCredits)
            {
                ___groupCredits = 1000;
            }            
        }
    }
}
