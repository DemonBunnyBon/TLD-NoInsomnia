using ModSettings;

namespace NoInsomniaMod
{
    internal class Settings : JsonModSettings
    {
        internal static Settings instance = new Settings();

        [Section("Insomnia")]

        [Name("Disable Insomnia")]
        [Description(" [!!Requires Scene Reload!!] Completely removes the insomnia system from the game. (It is possible this won't remove insomnia risk)")]
        public bool EnableMod = true;

        [Section("Glimmer Fog")]

        [Name("Disable Glimmer Fog (Experimental)")]
        [Description("[EXPERIMENTAL!, !!Requires Scene Reload!!] Should completely disable glimmer fog, however it is unknown if this works 100%. WARNING: Progressing through TALES might become IMPOSSIBLE without Glimmer Fog, use at your own risk!.")]
        public bool NoFog = false;
    }
}
