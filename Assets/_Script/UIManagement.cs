using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagement : MonoBehaviour
{
    static public UIManagement instance;
    public GameObject btnGameOver;

    private void Awake()
    {
        instance = this;
        btnGameOver = GameObject.Find("ButtonGameOver");
        btnGameOver.SetActive(false);
    }
}
