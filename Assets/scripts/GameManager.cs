using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int P1Lives;
    public int P2Lives;

    public GameObject player1;
    public GameObject player2;

    public GameObject score;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (P1Lives <= 0)
        {
            player1.SetActive(false);
            gameOver.SetActive(true);
        }
        if (P2Lives <= 0)
        {
            player2.SetActive(false);
            gameOver.SetActive(true);
        }
    }

    public void HurtP1()
    {
        P1Lives -= 1;

        for (int i = 0; i < P1Lives; i++)
        {

        }
    }
    public void HurtP2()
    {
        P2Lives -= 1;
    }
}
