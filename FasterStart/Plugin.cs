using BepInEx;
using MoreMoneyStart.Patches;
using HarmonyLib;
using BepInEx.Configuration;
using BepInEx.Logging;
namespace MoreMoneyStart
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class MoreMoneyStart : BaseUnityPlugin
    {
        private const string modGUID = "299792458.MoreMoneyStart";
        private const string modName = "MoreMoneyStart";
        private const string modVersion = "3.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);
        public ConfigEntry<int> startingAmount;
        public static MoreMoneyStart Instance;

        void Awake()
        {
            if (!Instance)
            {
                Instance = this;
            }
            startingAmount = Config.Bind("Starting Amount Config", "Starting Amount", 1000, "The starting amount can be configured here");
            harmony.PatchAll(typeof(TimeOfDayAwakePatch));
        }
    }
}
