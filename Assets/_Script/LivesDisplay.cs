using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    public int live = 3;
    public Text livesText;
    static public LivesDisplay instance;
    private void Awake()
    {
        instance = this;    
    }

    private void Start()
    {
        UpdateLiveText();
    }
     public void DecreaseLives()
    {
        live--;
        UpdateLiveText();
    }

    private void UpdateLiveText()
    {
        livesText.text = "Heart :" + live.ToString();
    }
}
