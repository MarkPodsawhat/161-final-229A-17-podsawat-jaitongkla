using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public override void Cast()
    {
        base.Cast();
        Debug.Log("Charging flame power...");
    }

    public override void Cast(string target)
    {
        base.Cast(target);
        Debug.Log($"{target} is looking you");
    }

    public override void Cast(string target, int damage)
    {
        base.Cast(target, damage);
        Debug.Log($"{target} is dead.");
    }



    private void Start()
    {
        Cast();
        Cast("Slime");
        Cast("Slime", 20);
        Debug.Log("=====================================");
    }
}
