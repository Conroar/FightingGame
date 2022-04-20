using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class LossBonusPlus : MonoBehaviour
{
    public TMP_Text pointsText;

    public void AddLossBonus()
    {
        Economy.roundLossBonus += 10;
        pointsText.text = "Loss Bonus: " + Economy.roundLossBonus.ToString();
    }

    public void getLossBonus()
    {

        pointsText.text = "Loss Bonus: " + Economy.roundLossBonus.ToString();
    }

    public void taxLossBonus()
    {
        Economy.roundLossBonus -= 10;
        pointsText.text = "Loss Bonus: " + Economy.roundLossBonus.ToString();
    }
} 
 