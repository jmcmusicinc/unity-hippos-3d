using UnityEngine;
using System.Collections;
using System;
using System.Diagnostics;

public class Countdown : MonoBehaviour
{
    private const int boxWidth = 200;
    private Stopwatch stopwatch;
    public int countDown;

    void Start()
    {
        stopwatch = new Stopwatch();
        stopwatch.Start();
    }

    public void OnGUI()
    {
        int elapsed = (countDown - stopwatch.Elapsed.Seconds);

        GUI.enabled = true;
        GUILayout.BeginArea(new Rect(150, 10, 200, 500));
        GUILayout.BeginHorizontal();

        GUILayout.Box("Countdown: " + elapsed, GUILayout.Width(boxWidth));

        GUILayout.EndHorizontal();
        GUILayout.EndArea();


        if(elapsed <= 0)
        {
            var script = GetComponent<EndGame>();
            script.ShowEndGame(true);
        }
    }


}
