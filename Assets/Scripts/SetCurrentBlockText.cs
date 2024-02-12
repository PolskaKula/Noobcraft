using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetCurrentBlockText : MonoBehaviour
{
    TMP_Text CurrentBlock;

    void Start()
    {
        CurrentBlock= GetComponent<TMP_Text>();
    }

    void Update()
    {
        CurrentBlock.text = "Current Block: " + GameManager.GM.ChosenBlockString;
    }
}
