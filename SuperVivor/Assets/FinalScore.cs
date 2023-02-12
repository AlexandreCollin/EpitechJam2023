using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text text;

    void Start()
    {
        text.text = DateTime.Now.Subtract(TimeScore.startTime).Seconds.ToString();
    }
}
