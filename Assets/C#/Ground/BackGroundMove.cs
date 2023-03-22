using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    public bool InputLeft;
    public bool InputRight;
    float A;
    public float speed;
    PlayerMove playermove;
    // Start is called before the first frame update
    void Start()
    {
        playermove = FindObjectOfType<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InputLeft == true)
        {
            A = -1f;
        }
        else if (InputRight == true)
        {
            A = 1f;
        }
        else if (InputLeft == true && InputRight == true)
        {
            A = 0;
        }
        else
        {
            A = 0;
        }
        speed = playermove.speed / 2.5f;
        float x = Input.GetAxis("Horizontal");
        Vector3 dir = new Vector3(A, 0, 0);
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
