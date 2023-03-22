using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPIconPercent : MonoBehaviour
{
    PlayerHP playerHP;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        playerHP = FindObjectOfType<PlayerHP>();
    }

    // Update is called once per frame
    void Update()
    {
        float Percent = playerHP.HP * 10;
        text.text = Percent + "%";
    }
}
