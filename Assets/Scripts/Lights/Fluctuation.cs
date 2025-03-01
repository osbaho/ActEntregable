using UnityEngine;

public class CandleLight : MonoBehaviour
{
    public Light pointLight;
    public float baseIntensity = 1.0f;  // Intensidad base de la luz
    public float fluctuationRange = 0.2f;  // Rango de fluctuación de la intensidad
    public float fluctuationSpeed = 5.0f;  // Velocidad de fluctuación

    void Update()
    {
        // Generar una fluctuación aleatoria en la intensidad de la luz
        float fluctuation = Mathf.PerlinNoise(Time.time * fluctuationSpeed, 0.0f) * fluctuationRange;
        pointLight.intensity = baseIntensity + fluctuation;
    }
}
