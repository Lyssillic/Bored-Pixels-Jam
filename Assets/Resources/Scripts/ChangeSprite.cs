using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public float clickResistance = .4f;
    Sprite[] lifeSprites;
    int index = 0; 

    void Awake()
    {
        lifeSprites = Resources.LoadAll<Sprite>("Sprites/Life");
        StartCoroutine(DepleteHeart());
    }

    public IEnumerator DepleteHeart()
    {
        while (true)
        {
            if (index != 0)
            {
                index--;
            }
            gameObject.GetComponent<SpriteRenderer>().sprite = lifeSprites[index];
            yield return new WaitForSeconds(clickResistance);
        }
    }

    private void OnMouseDown()
    {
        if (index == lifeSprites.Length - 2)
        {
            Destroy(gameObject);
        }
        else
        {
            index++;
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = lifeSprites[index];
    }
}
