using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOutSet : MonoBehaviour
{
    public GameObject outImage;
    // Start is called before the first frame update
    public void Out()
    {
        outImage.SetActive(false);
    }
}
