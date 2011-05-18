using UnityEngine;
using System.Collections;
using System;
using System.Diagnostics;

public class Countdown : MonoBehaviour
{
    private const int boxWidth = 200;
    private Stopwatch stopwatch;
    public int countDown;

    void Awake()
    {
        stopwatch = new Stopwatch();
        stopwatch.Start();
    }

    public void OnGUI()
    {
        GUI.enabled = true;
        GUILayout.BeginArea(new Rect(150, 10, 200, 500));
        GUILayout.BeginHorizontal();

        GUILayout.Box("Countdown: " + (countDown - stopwatch.Elapsed.Seconds), GUILayout.Width(boxWidth));

        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }


}
