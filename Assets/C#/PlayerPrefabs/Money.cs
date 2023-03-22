using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public Text Text;
    private int value;
    // Update is called once per frame
    void Update()
    {
        value = PlayerPrefs.GetInt("Money", 0);
        PlayerPrefs.Save();
        Text.text = "Money : " + value.ToString() + "$";
    }
}
