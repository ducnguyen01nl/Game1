using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameReceiver : MonoBehaviour
{
    public int hp = 1;

    public virtual bool IsDead()
    {
        return hp <= 0;
    }

    public virtual void Receive(int damage)
    {
        hp -= damage;
    }
}
