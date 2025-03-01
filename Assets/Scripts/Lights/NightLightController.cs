using UnityEngine;

public class NightLightController : MonoBehaviour
{
    public Light directionalLight;
    public Light[] pointLights;

    void Start()
    {
        if (directionalLight != null)
        {
            SetNightLightSettings();
        }
        else
        {
            Debug.LogWarning("Directional Light not assigned.");
        }

        if (pointLights != null && pointLights.Length > 0)
        {
            SetPointLightsSettings();
        }
        else
        {
            Debug.LogWarning("Point Lights not assigned.");
        }
    }

    void SetNightLightSettings()
    {
        // Configurar la luz direccional como "baked"
        directionalLight.lightmapBakeType = LightmapBakeType.Baked;

        // Color de luz nocturna (casi sin luna)
        directionalLight.color = new Color(0.039f, 0.039f, 0.180f);

        // Intensidad de la luz
        directionalLight.intensity = 0.1f;

        // Ajustes de sombras
        directionalLight.shadowResolution = UnityEngine.Rendering.LightShadowResolution.Medium;
        directionalLight.shadowBias = 0.05f;
        directionalLight.shadowNormalBias = 0.4f;

        // Sombras suaves
        directionalLight.shadows = LightShadows.Soft;

        Debug.Log("Night light settings applied.");
    }

    void SetPointLightsSettings()
    {
        foreach (var pointLight in pointLights)
        {
            // Configurar las luces tipo "point light" como "realtime"
            pointLight.lightmapBakeType = LightmapBakeType.Realtime;

            // Asegurar sombras en tiempo real
            pointLight.shadows = LightShadows.Soft;

            Debug.Log("Point light settings applied.");
        }
    }
}
