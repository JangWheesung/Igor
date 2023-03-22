using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret2 : MonoBehaviour
{
    float rotz2 = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && rotz2 <= 50)
        {
            rotz2 += 0.05f;
        }
        if (Input.GetKey(KeyCode.DownArrow) && rotz2 >= 0)
        {
            rotz2 -= 0.05f;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && rotz2 == 0)
        {
            rotz2 = 0;
        }
        transform.rotation = Quaternion.Euler(0, 0, -rotz2);
    }
}
