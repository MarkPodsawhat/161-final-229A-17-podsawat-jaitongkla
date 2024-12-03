using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName = "";


    public void Init(string shape)
    {
        shapeName = shape;
    }

    public abstract float CalculateArea();

    public virtual void Resize()
    {
        Debug.Log("Resizing Shape...");
    }

    public void Draw()
    {
        Debug.Log("Drawing Shape");
    }
}
