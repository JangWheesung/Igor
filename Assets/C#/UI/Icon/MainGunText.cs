using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGunText : MonoBehaviour
{
    public GameManager gameManager;
    public Fire fire;
    public GunFire gunFire;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fire.reset >= 10 && gameManager.BigGun == true)
        {
            text.text = "1 / 1";
        }
        else if (fire.reset < 10 && gameManager.BigGun == true)
        {
            text.text = "0 / 1";
        }
        else
        {
            text.text = 10 - gunFire.re + " / 10";
        }
    }
}
