using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamagaReceiver : DameReceiver
{
    private void Reset()
    {
        hp = 3;
    }

    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (IsDead())
        {
            UIManagement.instance.btnGameOver.SetActive(true);
            Time.timeScale = 0f;
            //Destroy(gameObject);

            //EffectManagement.instance.SpawnVFX()
        }
    }
}
