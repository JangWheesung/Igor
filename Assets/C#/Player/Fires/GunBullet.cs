using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBullet : MonoBehaviour
{
    private Vector3 MoveVector;
    Transform Tank;
    // Start is called before the first frame update
    void Start()
    {
        Tank = transform.parent.parent.GetComponent<Transform>();
        transform.localEulerAngles = new Vector3(0f, 0f, Tank.transform.rotation.z);
        transform.SetParent(null);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += transform.right * 1.5f;
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
