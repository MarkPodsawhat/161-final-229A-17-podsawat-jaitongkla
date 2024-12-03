using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {
        Debug.Log("Casting spell...");
    }

    public virtual void Cast(string target)
    {
        Debug.Log($"Targer is {target}");
    }

    public virtual void Cast (string target, int damage)
    {
        Debug.Log($"Spell deal {damage} to {target}");
    }
}
