using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class HippoRepository
{
    private static IDictionary<string, Hippo> _hippos;

    static HippoRepository()
    {
        _hippos = new Dictionary<string, Hippo>();
        _hippos.Add("Hippo1", new Hippo("Player 1"));
        _hippos.Add("Hippo2", new Hippo("Player 2"));
        _hippos.Add("Hippo3", new Hippo("Player 3"));
        _hippos.Add("Hippo4", new Hippo("Player 4"));
    }


    public static Hippo Get(string key)
    {
        return _hippos[key];
    }
}
