using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class KillBonusPlus : MonoBehaviour
{
    public TMP_Text pointsText;

    public void AddKillBonus()
    {
        Economy.killBonus += 10;
        pointsText.text = "Kill Bonus: " +  Economy.killBonus.ToString();
    }

    public void getKillBonus()
    {

        pointsText.text = "Kill Bonus: " + Economy.killBonus.ToString();
    }

    public void taxKillBonus()
    {
        Economy.killBonus -= 10;
        pointsText.text = "Kill Bonus: " + Economy.killBonus.ToString();
    }
} 