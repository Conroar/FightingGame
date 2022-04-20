using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class StartMoneyPlus : MonoBehaviour
{
    public TMP_Text pointsText;
    
    public void AddStartMoney()
    {
        Economy.startMoney += 10;
        pointsText.text = "Start Money: " + Economy.startMoney.ToString();
    }

    public void getStartMoney()
    {
        
        pointsText.text = "Start Money: " + Economy.startMoney.ToString();
    }

    public void taxStartMoney()
    {
        Economy.startMoney -= 10;
        pointsText.text = "Start Money: " + Economy.startMoney.ToString();
    }
}
