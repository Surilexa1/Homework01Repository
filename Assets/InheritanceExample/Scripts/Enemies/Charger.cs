using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    public GameObject powerSpawn;
    protected override void OnHit()
    {
        //inc speed on hit
        MoveSpeed *= 2;
    }
    public override void Kill()
    {
        AudioHelper.PlayClip2D(_deathSound, 1, .1f);
        Instantiate(powerSpawn, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }
}
