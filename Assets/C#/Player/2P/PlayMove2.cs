using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMove2 : MonoBehaviour
{
    float speed = 7;
    public GameObject gas;
    // Start is called before the first frame update
    void Start()
    {
        gas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(x, 0, 0);
        transform.Translate(dir * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            gas.gameObject.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            gas.gameObject.SetActive(false);
        }
    }
}
