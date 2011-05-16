using UnityEngine;
using System.Collections;

public class Hippo
{
    public Hippo(string keyBinding)
    {
        KeyBinding = keyBinding;
    }

    public void UpdateBalls()
    {
        Balls++;
    }

    public string KeyBinding { get; private set; }
    public int Balls { get; private set; }
}
