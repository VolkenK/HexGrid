using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHex : MonoBehaviour {

    [SerializeField] private int width = 5;
    [SerializeField] private int height = 5;
    [SerializeField] public GameObject Prefab;

    void Start()
    {
        for (int x = 0; x < height; x++)
        {
            for (int z = 0; z < width; z++)
            {
                GameObject obj = Instantiate(Prefab);
                Vector3 spawnPosition = new Vector3(0 + (3 * x) + (1.5f * (z % 2)), 0, 0 + ((Mathf.Sqrt(2) * z) - (0.5f * z)));
                obj.transform.position = spawnPosition;
            }
        }
    }
}
