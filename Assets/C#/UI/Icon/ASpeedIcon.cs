using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASpeedIcon : MonoBehaviour
{
    Fire fire;
    public SpriteRenderer spriteRenderer;
    float FirstStat;
    // Start is called before the first frame update
    void Start()
    {
        fire = FindObjectOfType<Fire>();
        spriteRenderer.color = Color.green;
        FirstStat = fire.DelayPower;
    }

    // Update is called once per frame
    void Update()
    {
        if (fire.DelayPower != FirstStat)
        {
            spriteRenderer.color = Color.red;
        }
    }
}
