using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Turret turret;
    Transform tank;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        turret = FindObjectOfType<Turret>();
        tank = GameObject.FindWithTag("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(25, turret.transform.rotation.z * 37.5f * ((tank.transform.rotation.z * 1.05f) + 0.95f)) * 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        else if (false)
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
