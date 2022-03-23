using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1Switching : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite[] spriteArray;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = spriteArray[0];
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
        if (spriteRenderer.sprite == spriteArray[0])
            spriteRenderer.sprite = spriteArray[1];
        else if (spriteRenderer.sprite == spriteArray[1])
            spriteRenderer.sprite = spriteArray[2];
        else if (spriteRenderer.sprite == spriteArray[2])
            spriteRenderer.sprite = spriteArray[3];
        else if (spriteRenderer.sprite == spriteArray[3])
            spriteRenderer.sprite = spriteArray[0];
    }

    // public Queue myQ = new Queue();

}
