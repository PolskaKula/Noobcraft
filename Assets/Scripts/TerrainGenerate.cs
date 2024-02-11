using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerate : MonoBehaviour
{
    [SerializeField] private GameObject Grass;
    [SerializeField] private GameObject Dirt;
    [SerializeField] private GameObject Stone;

    void Start()
    {
        for (int i = -25; i < 25; i++)
        {
            for (int j = -25; j < 25; j++)
            {
                Instantiate(Grass, new Vector3(i, 0, j), Quaternion.identity);
            }
        }
        for (int i = -25; i < 25; i++)
        {
            for (int j = -25; j < 25; j++)
            {
                for(int k = -2; k < 0; k++)
                Instantiate(Dirt, new Vector3(i, k, j), Quaternion.identity);
            }
        }
        for(int i = -25; i < 25; i++)
        {
            for (int j = -25; j < 25; j++)
            {
                for (int k = -5; k < -2; k++)
                    Instantiate(Stone, new Vector3(i, k, j), Quaternion.identity);
            }
        }
    }

    void Update()
    {
        
    }
}
