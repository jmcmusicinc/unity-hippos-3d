using System;

public class Game
{
    public Game()
    {
        this.Preferences = new Preferences();
    }

    public Game(Preferences preferences)
    {
        this.Preferences = preferences;
    }

    public Preferences Preferences { get; set; }
}