using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sign : MonoBehaviour
{
    public string UnlockStageName;
    public Image ClearImage;
    public GameObject tank;
    public string name;
    public bool clear;
    // Start is called before the first frame update
    void Start()
    {
        ClearImage.gameObject.SetActive(false);
        clear = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (tank.transform.position.x >= transform.position.x)
        {
            clear = true;
            PlayerPrefs.SetInt(UnlockStageName, 1);
            PlayerPrefs.Save();
            ClearImage.gameObject.SetActive(true);
        }
    }
}
