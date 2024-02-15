using UnityEngine;
using Il2Cpp;
using MelonLoader;





namespace NoInsomniaMod
{
    internal static class NoInsomniaUtils
    {

        public static bool IsScenePlayable(string scene)
        {
            return !(string.IsNullOrEmpty(scene) || scene.Contains("MainMenu") || scene == "Boot" || scene == "Empty");
        }




    }






}


