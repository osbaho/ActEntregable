using UnityEngine;

public class Oscillation : MonoBehaviour
{
    public float amplitude = 0.5f; // La amplitud del movimiento
    public float frequency = 1f; // La frecuencia del movimiento

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float yOffset = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(startPos.x, startPos.y + yOffset, startPos.z);
    }
}
