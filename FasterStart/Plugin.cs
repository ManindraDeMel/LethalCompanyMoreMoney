using BepInEx;
using BepInEx.Logging;
using FasterStart.Patches;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasterStart
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class FasterStart : BaseUnityPlugin
    {
        private const string modGUID = "299792458.FasterStart";
        private const string modName = "Faster Start";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static FasterStart Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (!Instance)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("Test");

            harmony.PatchAll(typeof(FasterStart));
            harmony.PatchAll(typeof(MoreMoney));
        }
    }
}
