﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAmmo : MonoBehaviour
{
    public int ammo = 30;
    public Text ammoDisplay;

    void Update()
    {
        ammoDisplay.text = "Ammo: " + ammo.ToString();
    }

    public void SetAmmo(int ammoCount)
    {
        ammo = ammoCount;
    }
    public void AddAmmo(int ammoCount)
    {
        ammo += ammoCount;
    }
    public void LoseAmmo(int ammoCount)
    {
        ammo -= ammoCount;
    }
}