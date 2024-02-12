using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Grass, Dirt, Stone, Wood, Leaves;
    public int ChosenBlock = 1;
    public string ChosenBlockString;

    public static GameManager GM;

    void Start()
    {
        if (GM == null) GM = this;
    }

    void Update()
    {
        ScrollConfig();
        SetBlock();
    }

    void ScrollConfig()
    {
        if (Input.mouseScrollDelta.y > 0)
        {
            ChosenBlock++;
            if (ChosenBlock > 5) ChosenBlock = 1;
        }
        else if (Input.mouseScrollDelta.y < 0)
        {
            ChosenBlock--;
            if (ChosenBlock < 1) ChosenBlock = 5;
        }
    }

    private void SetBlock()
    {
        switch (ChosenBlock)
        {
            case 1:
                ChosenBlockString = "Grass";
                break;

            case 2:
                ChosenBlockString = "Dirt";
                break;

            case 3:
                ChosenBlockString = "Stone";
                break;

            case 4:
                ChosenBlockString = "Wood";
                break;

            case 5:
                ChosenBlockString = "Leaves";
                break;
        }
    }
}
