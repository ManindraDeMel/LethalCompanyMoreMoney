using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasterStart.Patches
{
    [HarmonyPatch(typeof(Terminal))]
    internal class MoreMoney
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        static void betterStartingAmount(ref int ___groupCredits)
        {
            ___groupCredits = 1000;
        }
    }
}
