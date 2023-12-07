using HarmonyLib;
namespace MoreMoneyStart.Patches
{
    [HarmonyPatch(typeof(Terminal))]
    internal class MoreMoney
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        static void betterStartingAmount(Terminal __instance, ref int ___groupCredits)
        {
            QuotaSettings quotaSettings = new QuotaSettings();

            if (___groupCredits == quotaSettings.startingCredits && TimeOfDay.Instance.daysUntilDeadline == 3 && TimeOfDay.Instance.profitQuota == 130) // isolate to the first day of a new game
            {
                ___groupCredits = MoreMoneyStart.Instance.startingAmount.Value;
            }
        }
    }
    [HarmonyPatch(typeof(StartOfRound))]
    internal class ResetTerminal
    {
        [HarmonyPatch("ResetShip")]
        [HarmonyPostfix]
        static void resetTerminal()
        {
            UnityEngine.Object.FindObjectOfType<Terminal>().groupCredits = MoreMoneyStart.Instance.startingAmount.Value;
        }
    }
}