using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponHandler : MonoBehaviour
{
    [SerializeField] Text weaponText;
    [SerializeField] InputField weaponNameField;
    [SerializeField] InputField weaponCostField;
    List<Weapon> weapons;

    void Start()
    {
        weapons = Database.GetAll();
        DisplayWeapons();
    }

    void DisplayWeapons()
    {
        string allWeaponString = "";

        foreach (var weapon in weapons)
        {
            allWeaponString += weapon + "\n";
        }

        weaponText.text = allWeaponString;
    }

    public void CreateWeapon()
    {
        var weapon = new Weapon(weaponNameField.text, int.Parse(weaponCostField.text));
        weapons.Add(weapon);
        Database.Insert(weapon);
        DisplayWeapons();
    }
}
