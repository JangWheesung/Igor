using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public bool InputLeft;
    public bool InputRight;
    float A;
    public float speed;
    public PlayerStat stat;
    public AudioSource TankMoveSound;
    // Start is called before the first frame update
    void Awake()
    {
        speed = stat.Speed + (PlayerPrefs.GetInt("SPEED", 0) / 2f);
        PlayerPrefs.Save();
        TankMoveSound.volume = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (InputLeft == true)
        {
            A = -1f;
            TankMoveSound.volume = 0.6f;
        }
        else if (InputRight == true)
        {
            A = 1f;
            TankMoveSound.volume = 0.6f;
        }
        else if (InputLeft == true && InputRight == true)
        {
            A = 0;
            TankMoveSound.volume = 0.25f;
        }
        else
        {
            A = 0;
            TankMoveSound.volume = 0.25f;
        }
        float x = Input.GetAxis("Horizontal");
        Vector3 dir = new Vector3(A, 0, 0);
        transform.Translate(dir * speed * Time.deltaTime);
        Mathf.Clamp(TankMoveSound.volume, 0.03f, 0);
    }
}
