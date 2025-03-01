using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class WaterWaves : MonoBehaviour
{
    public float waveHeight = 0.5f;
    public float waveFrequency = 0.5f;
    public float waveSpeed = 1f;

    private Vector3[] baseVertices;
    private Mesh mesh;

    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        baseVertices = mesh.vertices;
    }

    void Update()
    {
        Vector3[] vertices = new Vector3[baseVertices.Length];
        for (int i = 0; i < vertices.Length; i++)
        {
            Vector3 vertex = baseVertices[i];
            vertex.y += Mathf.Sin(Time.time * waveSpeed + baseVertices[i].x * waveFrequency + baseVertices[i].z * waveFrequency) * waveHeight;
            vertices[i] = vertex;
        }
        mesh.vertices = vertices;
        mesh.RecalculateNormals();
    }
}
