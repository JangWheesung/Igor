using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpUpgrade : MonoBehaviour
{
    private int Moneyvalue;
    private int value;
    public void HP(string name)
    {
        if (PlayerPrefs.GetInt("Money", 0) >= 10)
        {
            Debug.Log(PlayerPrefs.GetInt("Money", 0));
            Moneyvalue = PlayerPrefs.GetInt("Money", 0);
            PlayerPrefs.SetInt("Money", Moneyvalue -= 10);
            value = PlayerPrefs.GetInt(name, 0);
            PlayerPrefs.SetInt(name, value + 1);
            Debug.Log(PlayerPrefs.GetInt("Money", 0));
            PlayerPrefs.Save();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
