using System;
using UnityEngine;

[CreateAssetMenu]
public class WeaponsSwitch : ScriptableObject
{
    public enum Weapons
    {
        Sword,
        Spear,
        Crossbow,
        Bow,
        Boomerang,
    }

    public Weapons currentWeapons;

    public void RunCurrentDefence()
    {
        switch (currentWeapons)
        {
            case Weapons.Sword:
                break;
            case Weapons.Spear:
                break;
            case Weapons.Crossbow:
                break;
            case Weapons.Bow:
                break;
            case Weapons.Boomerang:
                break;
        }
    }
}
