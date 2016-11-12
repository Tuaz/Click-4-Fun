using UnityEngine;
using System.Collections;

public class BaseClass {

    private int strength;
    private int stamina;

    private int armor;
    private int speed;
    private int hitpoints;

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }
    public int Armor
    {
        get { return armor; }
        set { armor = value; }
    }
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public int Hitpoints
    {
        get { return hitpoints; }
        set { hitpoints = value; }
    }
}
