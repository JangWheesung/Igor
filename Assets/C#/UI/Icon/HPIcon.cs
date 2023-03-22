using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPIcon : MonoBehaviour
{
    PlayerHP playerHP;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        playerHP = FindObjectOfType<PlayerHP>();
        spriteRenderer.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHP.HP >= 7)
        {
            spriteRenderer.color = Color.green;
        }
        else if (playerHP.HP >= 4)
        {
            spriteRenderer.color = Color.yellow;
        }
        else
        {
            spriteRenderer.color = Color.red;
        }
    }
}
