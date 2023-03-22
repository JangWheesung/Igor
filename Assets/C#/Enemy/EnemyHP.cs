using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public GameObject Gas;
    public GameObject Fire;
    public Collider2D Collider1;
    public Collider2D Collider2;
    public EnemyStat enemyStat;
    EnemyTurret enemyTurret;
    EnemyFire enemyFire;
    public float HP;
    private int value;

    // Start is called before the first frame update
    void Start()
    {
        enemyTurret = transform.GetChild(0).GetComponent<EnemyTurret>();
        enemyFire = transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<EnemyFire>();
        enemyTurret.enabled = true;
        enemyFire.enabled = true;

        Gas.gameObject.SetActive(false);
        Fire.gameObject.SetActive(false);

        HP = enemyStat.HP * 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            value = PlayerPrefs.GetInt("Money", 0);
            PlayerPrefs.SetInt("Money", value + enemyStat.Pay);
            PlayerPrefs.Save();

            Gas.gameObject.SetActive(true);
            Fire.gameObject.SetActive(true);
            enemyTurret.enabled = false;
            enemyFire.enabled = false;
            Collider1.enabled = false;
            Collider2.enabled = false;

            HP += 10;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            HP -= 10;
        }
        if (collision.gameObject.CompareTag("PlayerGunBullet"))
        {
            --HP;
        }
    }
}
