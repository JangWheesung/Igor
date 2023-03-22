using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public bool InputUp;
    public bool InputDown;
    public float angle;
    public bool InputFire;
    public float reset = 10;
    public float DelayPower;
    public float re;
    public GameObject bullet;
    public PlayerStat stat;
    public GameObject Tank;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Delay());
        DelayPower = stat.GunAttactSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Angle();
        Fire();
    }
    void Angle()
    {
        if (InputUp == true && InputDown == false && angle <= 1)
        {
            angle += 0.03f;
        }
        if (InputDown == true && InputUp == false && angle >= -1)
        {
            angle -= 0.03f;
        }
        transform.rotation = Quaternion.Euler(0, 0, angle + (Tank.transform.rotation.z * 120));
    }
    void Fire()
    {
        if (InputFire == true && reset >= 10)
        {
            GameObject ex = Instantiate(bullet) as GameObject;
            ex.transform.SetParent(transform, false);
            ex.transform.position = transform.position;
            reset = 0;
            re++;
        }
    }
    IEnumerator Delay()
    {
        while (true)
        {
            if (re >= 9)
            {
                yield return new WaitForSeconds(1.5f);
                InputFire = false;
                re = 0;
            }
            yield return new WaitForSeconds(0.14f);
            reset = reset + DelayPower;
        }
    }
}
