using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_Button_Name: MonoBehaviour
{
    // Start is called before the first frame update
    public Text Textfield;

    void void SetText(string text)
    {
        Textfield.text = text;

    }
}
