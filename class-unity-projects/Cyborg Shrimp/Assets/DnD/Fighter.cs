using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : Player
{
    public int superiorityDice = 1;

    protected void ActionServed()
    {
        var use = superiorityDice;
    }
    
}
