using UnityEngine;

public class HexMesh : MonoBehaviour
{

    float zPos = Mathf.Sqrt(0.75f);

    // Use this for initialization
    void Start()
    {


        Mesh m = new Mesh();
        Vector3[] vertices = new Vector3[12];
        vertices[0] = new Vector3(-0.5f, 0.5f, zPos);
        vertices[1] = new Vector3(0.5f, 0.5f, zPos);
        vertices[2] = new Vector3(1, 0.5f, 0);
        vertices[3] = new Vector3(0.5f, 0.5f, -zPos);
        vertices[4] = new Vector3(-0.5f, 0.5f, -zPos);
        vertices[5] = new Vector3(-1, 0.5f, 0);

        vertices[6] = new Vector3(-0.5f, 0, zPos);
        vertices[7] = new Vector3(0.5f, 0, zPos);
        vertices[8] = new Vector3(1, 0, 0);
        vertices[9] = new Vector3(0.5f, 0, -zPos);
        vertices[10] = new Vector3(-0.5f, 0, -zPos);
        vertices[11] = new Vector3(-1, 0, 0);


        m.vertices = vertices;

        m.triangles = new int[]
        {
           0, 1, 2,
           0, 2, 3,
           0, 3, 5,
           3, 4, 5,

           6, 1, 0,
           1, 6, 7,

           7, 2, 1,
           2, 7, 8,

           8, 3, 2,
           3, 8, 9,

           9, 4, 3,
           4, 9, 10,

           10, 5, 4,
           5, 10, 11,

           0, 5, 6,
           11, 6, 5,

           8, 7, 6,
           9, 8, 6,
           11, 9, 6,
           11, 10, 9
        };

        GetComponent<MeshFilter>().mesh = m;
        m.RecalculateNormals();
        GetComponent<MeshCollider>().sharedMesh = m;
    }
    
}