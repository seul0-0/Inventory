using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    public int Attack;
    public int Shield;
    public int Health;
    public int Critical;
    public int Level;
    public string Name;
    public int Coin;
    public string Userid;

    public Character(int attack, int shield, int health, int critical, int level, string name, int coin, string userid)
    {
        Attack = attack;
        Shield = shield;
        Health = health;
        Critical = critical;
        Level = level;
        Name = name;
        Coin = coin;
        Userid = userid;
    }
    
}
