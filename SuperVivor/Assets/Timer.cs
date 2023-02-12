using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text text;

    void Start()
    {
        Debug.Log("Start timer");
        TimeScore.startTime = DateTime.Now;
    }

    private void Update()
    {
        text.text = DateTime.Now.Subtract(TimeScore.startTime).Seconds.ToString();
    }
}
