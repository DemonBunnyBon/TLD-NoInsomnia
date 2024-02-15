using NoInsomniaMod;
using Il2CppTLD.BigCarry;
using Il2CppTLD.Gear;
using System.Runtime.InteropServices;


namespace NoInsomniaMod
{
	public class NoInsomnia : MelonMod
	{
		public override void OnInitializeMelon()
		{
			
            MelonLoader.MelonLogger.Msg(System.ConsoleColor.Cyan, "Sleep in peace, No Insomnia is here!");
            Settings.instance.AddToModSettings("No Insomnia");
        }
		private static bool Done;
		public static bool SceneLoaded;

		public override void OnSceneWasLoaded(int buildIndex, string sceneName) 
		{
			if(NoInsomniaUtils.IsScenePlayable(sceneName))  
			{
				SceneLoaded = true;

				Dostuff();
            }
			

		}

		public override void OnUpdate()
		{

		}

		private static void Dostuff()
		{


			if (Settings.instance.EnableMod == true)
			{
				if (GameManager.GetInsomniaComponent().HasInsomniaRisk() || GameManager.GetInsomniaComponent().HasInsomniaAffliction())
				{
					GameManager.GetInsomniaComponent().RemoveInsomniaAll();
					
				}
				GameManager.Destroy(GameManager.GetInsomniaComponent());
			}


			if (Settings.instance.NoFog == true)
			{
                GameManager.GetWeatherComponent().m_ChancesOfPickingElectrostaticFogInActivationWindow = 0;


                GameManager.GetWeatherComponent().m_ElectrostaticFogActivationWindowEnd = 0;


                GameManager.GetWeatherComponent().m_ElectrostaticFogActivationWindowStart = 0;

                GameManager.GetWeatherComponent().m_ElectrostaticFogSelectionWindowEnd = 0;

                GameManager.GetWeatherComponent().m_ElectrostaticFogSelectionWindowStart = 0;
            }






        }
	}
}