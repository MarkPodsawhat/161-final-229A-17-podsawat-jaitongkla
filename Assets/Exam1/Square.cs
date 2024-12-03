using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Square : Shape
{
    private int side = 20;


    public override void Resize()
    {
        base.Resize();
        Debug.Log("Resized to Square.");
    }

    public override float CalculateArea()
    {
        return side * side;
    }

    private void Start()
    {
        Init("Square");
        Draw();
        Resize();
        Debug.Log($"{shapeName} side is {side}");
        Debug.Log($"{shapeName} area is {CalculateArea()}");
        Debug.Log("=====================================");
    }
}
