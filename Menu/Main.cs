using HarmonyLib;
using TMPro;
using UnityEngine;
using static TMPro.TextMeshPro;
using static silliness.Menu.Customization;

namespace silliness.Menu
{
    [HarmonyPatch(typeof(GorillaLocomotion.GTPlayer))]
    [HarmonyPatch("LateUpdate", MethodType.Normal)]
    public class Main
    {
        public static void Prefix(GorillaLocomotion.GTPlayer __instance)
        {
            if (!HasLoaded)
            {
                HasLoaded = true;
                Launch();
            }
        }

        public static void Launch()
        {
            // Holder
            // this just goes to your hands or in front of you
            GameObject Holder = GameObject.Instantiate(HolderPrefab);
            Holder.transform.position = new Vector3(-66.5447f, 12.0491f, -81.8785f);
            
            // Menu Background
            Transform MenuBackground = Holder.gameObject.transform.Find("MenuBackground");
            Renderer MenuBackgroundRenderer = MenuBackground.GetComponent<Renderer>();
            MenuBackground.GetComponent<BoxCollider>().enabled = false;

            MenuBackgroundRenderer.material.shader = Shader.Find("GorillaTag/UberShader");
            MenuBackgroundRenderer.material.color = MenuBackgroundColor;
            
            // Menu Background
            Transform MenuBackground2 = Holder.gameObject.transform.Find("MenuBackground2");
            Renderer MenuBackgroundRenderer2 = MenuBackground2.GetComponent<Renderer>();
            MenuBackground2.GetComponent<BoxCollider>().enabled = false;

            MenuBackgroundRenderer2.material.shader = Shader.Find("GorillaTag/UberShader");
            MenuBackgroundRenderer2.material.color = MenuBackgroundColor;
            
            
            
            // Title
            Transform Title = Holder.gameObject.transform.Find("BackgroundCanvas/Title");
            TextMeshProUGUI TitleTextTMP = Title.GetComponent<TextMeshProUGUI>();

            TitleTextTMP.color = (Color)TitleColor;
            
            // FPS Text
            Transform FPSText = Holder.gameObject.transform.Find("BackgroundCanvas/FPSText");
            TextMeshProUGUI FPSTextTMP = FPSText.GetComponent<TextMeshProUGUI>();

            FPSTextTMP.color = (Color)TitleColor;
            
            // FPS Text
            Transform VERText = Holder.gameObject.transform.Find("BackgroundCanvas/VERText");
            TextMeshProUGUI VERTextTMP = VERText.GetComponent<TextMeshProUGUI>();

            VERTextTMP.color = (Color)TitleColor;
        }
        
        public static bool HasLoaded = false;
        public static AssetBundle SillinessAssets = Utilities.AssetUtils.LoadBundle("silliness.Resources.silliness");
        public static GameObject HolderPrefab = SillinessAssets.LoadAsset<GameObject>("Holder");
    }
}