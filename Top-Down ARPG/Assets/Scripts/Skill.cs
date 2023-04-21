using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : ScriptableObject
{
    new public string name = "New Skill";
    public float manaCost = 0f;
    public GameObject projectile = null;

    public virtual void Cast(GameObject parent)
    {
        Debug.Log(name + " used.");
    }
}
