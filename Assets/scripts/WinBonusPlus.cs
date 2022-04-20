using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class WinBonusPlus : MonoBehaviour
{
    public TMP_Text pointsText;

    public void AddWinBonus()
    {
        Economy.roundWinBonus += 10;
        pointsText.text = "Win Bonus: " + Economy.roundWinBonus.ToString();
    }

    public void getWinBonus()
    {

        pointsText.text = "Win Bonus: " + Economy.roundWinBonus.ToString();
    }

    public void taxWinBonus()
    {
        Economy.roundWinBonus -= 10;
        pointsText.text = "Win Bonus: " + Economy.roundWinBonus.ToString();
    }
}