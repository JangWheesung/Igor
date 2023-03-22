using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public bool InputUp;
    public bool InputDown;
    private Transform Tank;
    public float rotz=0;
    // Start is called before the first frame update
    void Start()
    {
        Tank = transform.parent.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float angle = rotz + Tank.transform.rotation.z * 120;
        if (InputUp == true && InputDown == false && rotz <= 30)
        {
            rotz += 0.15f;
        }
        if (InputDown == true && InputUp == false && rotz >= 0)
        {
            rotz -= 0.15f;
        }
        transform.rotation = Quaternion.Euler(0,0, angle);
        //transform.rotation = Quaternion.Euler(0,0, -rotz / Tank.transform.rotation.z * 120);
    }
}