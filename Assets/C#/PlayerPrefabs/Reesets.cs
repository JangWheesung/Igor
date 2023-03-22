using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reesets : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("Money", 0);
        PlayerPrefs.GetInt("HP", 0);
        PlayerPrefs.GetInt("SPEED", 0);
        PlayerPrefs.GetInt("DELAY", 0);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("Money", 0);
        PlayerPrefs.SetInt("HP", 0);
        PlayerPrefs.SetInt("SPEED", 0);
        PlayerPrefs.SetInt("DELAY", 0);
    }
}
