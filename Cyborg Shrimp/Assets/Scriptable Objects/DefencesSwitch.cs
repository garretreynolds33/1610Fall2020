using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DefencesSwitch : ScriptableObject
{
    public enum Defences
    {
        Shield,
        ExtraHealth,
        Potions,
        SuperShield,
        Buffs,
        Armor,
    }

    public Defences currentDefence;

    public void RunCurrentDefence()
    {
        switch (currentDefence)
        {
            case Defences.Shield:
                
                break;
            case Defences.ExtraHealth:
                break;
            case Defences.Potions:
                break;
            case Defences.SuperShield:
                break;
            case Defences.Buffs:
                break;
           case Defences.Armor:
               break;
        }
    }
}
