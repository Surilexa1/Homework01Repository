using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PU_RapidFire : PowerUpBase
{
    
    protected TurretController t { get; set;}
    bool powerOn;
    float timeLimit;
    private void Awake()
    {
        t = FindObjectOfType<TurretController>();
        timeLimit = PowerupDuration;
        powerOn = false;
    }
    protected override void PowerUp()
    {
        print("RapidFire!");
        t.FireCooldown /= 2;
        
    }

    protected override void Duration()
    {
        if (timeLimit >= 0)
        {
            timeLimit -= Time.deltaTime;
        }
        if (timeLimit<= 0)
        {
            print("done");
            powerDown();
        }
    }
    protected override void powerDown()
    {
        t.FireCooldown *= 2;
        Destroy(gameObject);
    }

}
