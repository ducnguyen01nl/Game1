using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDameSender : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DameReceiver dameReceiver = collision.GetComponent<DameReceiver>();
        dameReceiver.Receive(1);
    }
}
