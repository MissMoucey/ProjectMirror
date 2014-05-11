using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class cItemClass : MonoBehaviour 
{
    // private variables for items
    private string name;
    private int value;
    private Rarity rarity;

    // default contructor for the items to be set
    public cItemClass()
    {
        name = "Need Name";
        value = 0;
        rarity = Rarity.Common;
    }
    //overloaded contructor to set the values
    public cItemClass(string n, int v, Rarity rare)
    {
        name = n;
        value = v;
        rarity = rare;
    }
    //getter and setter methods for variables
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Value
    {
        get { return this.value; }
        set { this.value = value; }
    }

    public Rarity Rare
    {
        get { return rarity; }
        set { rarity = value; }
    }
}
//enum for the rarity of the item
public enum Rarity
{
    Common,
    Uncommon,
    Rare
}
