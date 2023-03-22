using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGas : MonoBehaviour
{
    PlayerHP playerHP;
    PlayerMove playerMove;
    Fire fire;
    public GameObject SeventyPercentGas;
    public GameObject ThirtyPercentFire;
    public GameObject SpeedDebuffGas;
    public GameObject ASpeedDebuffGas;
    // Start is called before the first frame update
    void Start()
    {
        playerHP = GetComponent<PlayerHP>();
        playerMove = GetComponent<PlayerMove>();
        fire = transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Fire>();

        SeventyPercentGas.SetActive(false);
        ThirtyPercentFire.SetActive(false);
        SpeedDebuffGas.SetActive(false);
        ASpeedDebuffGas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        HPGas();
        DebuffGas();
    }
    void HPGas()
    {
        if (playerHP.HP < 7 && playerHP.HP >= 4)
        {
            SeventyPercentGas.SetActive(true);
        }
        else if (playerHP.HP < 4)
        {
            ThirtyPercentFire.SetActive(true);
        }
    }
    void DebuffGas()
    {
        if (playerMove.speed == 4.2f)
        {
            SpeedDebuffGas.SetActive(true);
        }
        if (fire.DelayPower == 0.6f)
        {
            ASpeedDebuffGas.SetActive(true);
        }
    }
}
