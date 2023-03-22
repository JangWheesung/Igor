using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blind : MonoBehaviour
{
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Black());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Black()
    {
        Color color = image.color;
        image.color = color;
        for (int i = 0; image.color.a > 0; i++)
        {
            color.a -= 0.01f;
            image.color = color;
            yield return new WaitForSeconds(0.01f);
        }
        gameObject.SetActive(false);
    }
}
