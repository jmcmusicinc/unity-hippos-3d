using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Scoring : MonoBehaviour 
{
    private const int boxWidth = 80;
    private const int area = 20;

    public void OnGUI()
    {
        GUI.enabled = true;
        GUILayout.BeginArea(new Rect(10, 10, 200, 500));
        GUILayout.BeginHorizontal();

        GUILayout.Box("Score", GUILayout.Width(boxWidth));

        GUILayout.EndHorizontal();

        AddPlayer("Player 1:" + HippoRepository.Get("Hippo1").Balls);
        AddPlayer("Player 2:" + HippoRepository.Get("Hippo2").Balls);
        AddPlayer("Player 3:" + HippoRepository.Get("Hippo3").Balls);
        AddPlayer("Player 4:" + HippoRepository.Get("Hippo4").Balls);

        GUILayout.EndArea();
    }

    public static void AddPlayer(string displayName)
    {
        GUILayout.BeginHorizontal();

        //if(GUILayout.Button("<", GUILayout.Width(buttonWidth)))
            //ChangeElement(category, false, anim);

        GUILayout.Box(displayName, GUILayout.Width(boxWidth));

        //if(GUILayout.Button(">", GUILayout.Width(buttonWidth)))
            //ChangeElement(category, true, anim);

        GUILayout.EndHorizontal();
    }
}
