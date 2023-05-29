using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    static public PlayerCtrl instance;

    private void Awake()
    {
        PlayerCtrl.instance = this;
    }
}
