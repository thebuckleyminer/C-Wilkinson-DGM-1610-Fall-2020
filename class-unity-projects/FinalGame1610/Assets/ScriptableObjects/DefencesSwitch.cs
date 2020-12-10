using System;
using UnityEngine;
[CreateAssetMenu]
public class DefencesSwitch : ScriptableObject
{
    public enum Defences
    {
        Shields,
        Potions,
        ExtraHealth,
        Buffs,
        SuperShield,
        Armor
    }

    public Defences currentDefence;

    public void RunCurrentDefence()
    {
        switch (currentDefence)
        {
            case Defences.Shields:
                // Function
                break;
            case Defences.Potions:
                // Function
                break;
            case Defences.ExtraHealth:
                // Function
                break;
            case Defences.Buffs:
                // Function
                break;
            case Defences.SuperShield:
                // Function
                break;
            case Defences.Armor:
                // Function
                break;
        }
    }
}
