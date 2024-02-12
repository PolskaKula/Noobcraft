using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerate : MonoBehaviour
{
    [SerializeField] private GameObject Grass;
    [SerializeField] private GameObject[] GrassBlocks;
    [SerializeField] private GameObject Dirt;
    [SerializeField] private GameObject[] DirtBlocks;
    [SerializeField] private GameObject Stone;
    [SerializeField] private GameObject[] StoneBlocks;
    private int counter = 0;

    void Start()
    {
        GrassBlocks = new GameObject[2500];

        for (int i = -25; i < 25; i++)
        {
            for (int j = -25; j < 25; j++)
            {
                GrassBlocks[counter] = Instantiate(Grass, new Vector3(i, 0, j), Quaternion.identity);
                counter++;
            }
        }

        DirtBlocks = new GameObject[5000];
        counter = 0;

        for (int i = -25; i < 25; i++)
        {
            for (int j = -25; j < 25; j++)
            {
                for(int k = -2; k < 0; k++)
                {
                    DirtBlocks[counter] = Instantiate(Dirt, new Vector3(i, k, j), Quaternion.identity);
                    counter++;
                }
            }
        }

        StoneBlocks = new GameObject[7500];
        counter = 0;

        for (int i = -25; i < 25; i++)
        {
            for (int j = -25; j < 25; j++)
            {
                for (int k = -5; k < -2; k++)
                {
                    StoneBlocks[counter] = Instantiate(Stone, new Vector3(i, k, j), Quaternion.identity);
                    counter++;
                }
            }
        }
    }

    void Update()
    {
        
    }
}
