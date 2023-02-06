using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected float PowerupDuration;

    protected abstract void PowerUp();
    protected abstract void Duration();
    protected virtual void OnHit()
    {
        PowerUp();
    }
    private void FixedUpdate()
    {
        Duration();
    }
    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            print("hit");
            OnHit();
            this.GetComponentInChildren<MeshRenderer>().enabled = false;
            this.GetComponent<Collider>().enabled = false;
        }
    }
    protected abstract void powerDown();
    
}

