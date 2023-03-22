using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public bool InputFire;
    public float reset = 10;
    public float DelayPower;
    public GameObject bullet;
    public PlayerStat stat;
    public GameObject tank;
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(Delay());
        DelayPower = stat.AttactSpeed + (PlayerPrefs.GetInt("DELAY", 0) / 5f);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        if (InputFire == true && reset >= 10f)
        {
            InputFire = false;
            GameObject ex = Instantiate(bullet);
            ex.transform.position = transform.position;
            tank.transform.Rotate(0, 0, 7);
            reset = 0;
        }
    }
    IEnumerator Delay()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            reset = reset + DelayPower;
        }
    }
}
