using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDebuff : MonoBehaviour
{
    PlayerMove playerMove;
    Fire fire;
    // Start is called before the first frame update
    void Start()
    {
        playerMove = GetComponent<PlayerMove>();
        fire = transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Fire>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            int debuff = Random.Range(0, 20);
            if (debuff == 0)
            {
                playerMove.speed *= 0.7f;
            }
            if (debuff == 1)
            {
                fire.DelayPower *= 1.3f;
            }
        }
    }
}
