using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    EnemyTurret enemyturret;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        enemyturret = transform.parent.parent.parent.GetComponent<EnemyTurret>();

        float error = Random.Range(-2, 3);
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(-25 + error, enemyturret.transform.rotation.z * -37.5f) * 100);
        transform.SetParent(null);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
