using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public EnemyTurret enemyturret;
    public GameObject bullet;
    public EnemyStat enemyStat;
    private float reset = 0;
    // Start is called before the first frame update
    void Start()
    {
        enemyturret = transform.parent.parent.GetComponent<EnemyTurret>();
        StartCoroutine(Delay());
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyturret.distance_x.x <= 110 && enemyturret.angle >= -7 && reset >= 10f)
        {
            GameObject ex = Instantiate(bullet) as GameObject;
            ex.transform.SetParent(transform, false);
            ex.transform.position = transform.position;
            reset = 0;
        }
    }
    IEnumerator Delay()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            reset = reset + enemyStat.AttactSpeed;
        }
    }
}