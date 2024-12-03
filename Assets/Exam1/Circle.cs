using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Circle : Shape
{
    private float radius = 5;


    public override void Resize()
    {
        base.Resize();
        Debug.Log("Resized to Circle.");
    }

    public override float CalculateArea()
    {
        return (float)(3.14 * radius * radius);
    }

    private void Start()
    {
        Init("Circle");
        Draw();
        Resize();
        Debug.Log($"{shapeName} side is {radius}");
        Debug.Log($"{shapeName} area is {CalculateArea()}");
        Debug.Log("=====================================");
    }
}
