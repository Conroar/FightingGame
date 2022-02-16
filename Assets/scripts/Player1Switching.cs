using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1Switching : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite[] spriteArray;
    // Start is called before the first frame update
    void Start()
    {
        spriteArray = Resources.LoadAll<Sprite>("test");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ChangeSprite();
        }
    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = spriteArray[0];
        spriteRenderer.sprite = spriteArray[1];
        spriteRenderer.sprite = spriteArray[2];
        spriteRenderer.sprite = spriteArray[3];
    }

    // public Queue myQ = new Queue();

}
