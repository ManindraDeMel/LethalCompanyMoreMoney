using BepInEx;
using MoreMoneyStart.Patches;
using HarmonyLib;
namespace MoreMoneyStart
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class MoreMoneyStart : BaseUnityPlugin
    {
        private const string modGUID = "299792458.MoreMoneyStart";
        private const string modName = "MoreMoneyStart";
        private const string modVersion = "1.1.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static MoreMoneyStart Instance;

        void Awake()
        {
            if (!Instance)
            {
                Instance = this;
            }
            harmony.PatchAll(typeof(MoreMoney));
        }
    }
}
