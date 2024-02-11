using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerate : MonoBehaviour
{
    [SerializeField] private GameObject Tree;
    private GameObject newTree;
    private float distance;
    [SerializeField] private int TreeRarity;

    void Start()
    {
        for (int i = -23; i < 23; i++)
        {
            for (int j = -23; j < 23; j++)
            {
                int TreeProb = Random.Range(0, TreeRarity);
                if (TreeProb == 1)
                {
                    if (distance > 12 || newTree == null) newTree = Instantiate(Tree, new Vector3(i, 1, j), Quaternion.identity);
                }
                if (newTree != null) distance = Vector3.Distance(newTree.transform.position, new Vector3(i, 1, j));
            }
        }
    }
}
