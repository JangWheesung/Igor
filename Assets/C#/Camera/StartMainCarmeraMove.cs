using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StartMainCarmeraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveY(0, 4);
        Screen.SetResolution(1920, 1080, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
