using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIcion : MonoBehaviour
{
    PlayerMove playerMove;
    public SpriteRenderer spriteRenderer;
    float FirstStat;
    // Start is called before the first frame update
    void Start()
    {
        playerMove = GameObject.FindWithTag("Player").GetComponent<PlayerMove>();
        spriteRenderer.color = Color.green;
        FirstStat = playerMove.speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMove.speed != FirstStat)
        {
            spriteRenderer.color = Color.red;
        }
        else
        {
            spriteRenderer.color = Color.green;
        }
    }
}
