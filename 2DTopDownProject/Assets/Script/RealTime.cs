using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class RealTime : MonoBehaviour
{
    [SerializeField] private TMP_Text realtime;

    private void Update()
    {
        
        realtime.text = DateTime.Now.ToString("HH : mm : ss");

    }




}
