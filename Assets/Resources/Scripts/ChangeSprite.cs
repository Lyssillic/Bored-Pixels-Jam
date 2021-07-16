using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{

    public Sprite[] lifeSprites;
    public int index = 0; 

    void Awake()
    {
        lifeSprites = Resources.LoadAll<Sprite>("Sprites/Life");
    }

    private void OnMouseDown()
    {
        if (index == lifeSprites.Length - 1)
        {
            index = 0;
        }
        else
        {
            index++;
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = lifeSprites[index];
    }


}
