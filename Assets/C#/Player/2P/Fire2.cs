using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire2 : MonoBehaviour
{
    private float reset = 10;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Delay());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && reset >= 10)
        {
            GameObject ex = Instantiate(bullet);
            ex.transform.position = transform.position;
            reset = 0;
        }
    }
    IEnumerator Delay()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            ++reset;
        }
    }
}
