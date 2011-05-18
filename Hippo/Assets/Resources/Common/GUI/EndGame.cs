using UnityEngine;
using System.Collections;
using System.Linq;

public class EndGame : MonoBehaviour
{
    private const int boxWidth = 500;
    private Hippo[] _hippos;
    private bool _show;   


    void Awake()
    {
        _hippos = new GameRepository().Get().Hippos;
    }


    public void ShowEndGame(bool show)
    {
        _show = show;
    }


    public void OnGUI()
    {
        if(_show)
        {
            var winner = _hippos.OrderByDescending(hippo => hippo.BallsEaten).First();

            var width = boxWidth / 2;

            GUILayout.BeginArea(new Rect((Screen.width / 2) - width, Screen.height / 2, boxWidth, 500));
            GUILayout.BeginHorizontal();
            GUILayout.Box("Game Over", new GUIStyle() { fontSize = 60 }, GUILayout.Width(boxWidth));
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUILayout.Box(winner.Identity + " wins!", GUILayout.Width(100));
            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }
    }

}
