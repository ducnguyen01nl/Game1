using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReceiver : DameReceiver
{
 
    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (IsDead())
        {
            Destroy(gameObject);
            EffectManagement.instance.SpawnVFX("EnemyDeadAnimation", transform.position, transform.rotation);
        }
    }
}
