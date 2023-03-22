using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public AudioSource audioSource;
    public Image RedScrene;
    public PlayerStat stat;
    public float HP;

    // Start is called before the first frame update
    void Start()
    {
        RedScrene.gameObject.SetActive(false);
        HP = stat.HP + PlayerPrefs.GetInt("HP", 0);
        PlayerPrefs.Save();
        audioSource.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            audioSource.enabled = true;
            audioSource.Play();
            --HP;
            if (HP <= 0)
            {
                RedScrene.gameObject.SetActive(true);
            }
        }
    }
}
