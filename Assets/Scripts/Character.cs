using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    public int A;
    public int S;
    public int H;
    public int C;
    public int Level;
    public string Name;
    public int Coin;
    public string Userid;

    public Character(int a, int s, int h, int c, int level, string name, int coin, string userid)
    {
        A = a;
        S = s;
        H = h;
        C = c;
        Level = level;
        Name = name;
        Coin = coin;
        Userid = userid;
    }
    
}
