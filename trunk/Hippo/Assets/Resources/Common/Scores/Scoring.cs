using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour 
{
    bool newCharacterRequested = true;
    bool firstCharacter = true;
    string nonLoopingAnimationToPlay;

    const float fadeLength = .6f;
    const int typeWidth = 80;
    const int buttonWidth = 20;
    const string prefName = "Score";



    public void OnGUI()
    {
        GUI.enabled = true;
        GUILayout.BeginArea(new Rect(10, 10, typeWidth + 2 * buttonWidth + 8, 500));

        // Buttons for changing the active character.
        GUILayout.BeginHorizontal();

        GUILayout.Box("Score", GUILayout.Width(typeWidth));

        //if(GUILayout.Button(">", GUILayout.Width(buttonWidth)))

        GUILayout.EndHorizontal();

        // Buttons for changing character elements.
        AddPlayer("Player 1:");
        AddPlayer("Player 2:");
        AddPlayer("Player 3:");
        AddPlayer("Player 4:");

        // Buttons for saving and deleting configurations.
        // In a real world application you probably want store these
        // preferences on a server, but for this demo configurations 
        // are saved locally using PlayerPrefs.
        //if(GUILayout.Button("Save Configuration"))
          //  PlayerPrefs.SetString(prefName, generator.GetConfig());

        //if(GUILayout.Button("Delete Configuration"))
        //    PlayerPrefs.DeleteKey(prefName);

        // Show download progress or indicate assets are being loaded.
        GUI.enabled = true;


        GUILayout.EndArea();
    }

    // Draws buttons for configuring a specific category of items, like pants or shoes.
    public static void AddPlayer(string displayName)
    {
        GUILayout.BeginHorizontal();

        //if(GUILayout.Button("<", GUILayout.Width(buttonWidth)))
            //ChangeElement(category, false, anim);

        GUILayout.Box(displayName, GUILayout.Width(typeWidth));

        //if(GUILayout.Button(">", GUILayout.Width(buttonWidth)))
            //ChangeElement(category, true, anim);

        GUILayout.EndHorizontal();
    }
}
