using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{
    double pauseTimer = 0.0;

    protected override void Move()
    {
        if (pauseTimer >= 0)
        {
            pauseTimer -= Time.deltaTime;
        }
        else
        {
            MoveSpeed = 0.05f;
        }
        if (MoveSpeed == 0)
        {
            return;
        }
        else
        {
            Vector3 moveDelta = transform.forward * MoveSpeed;
            RB.MovePosition(RB.position + moveDelta);
        }
    }

    protected override void OnHit()
    {
        MoveSpeed = 0;
        pauseTimer = 1;
    }
   
}
