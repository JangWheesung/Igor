using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeMax : MonoBehaviour
{
    public string name;
    private Button button;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        text = transform.GetChild(0).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.GetInt(name, 0);
        if (PlayerPrefs.GetInt(name, 0) >= 10)
        {
            Debug.Log(3456);
            text.text = "Max";
            button.enabled = false;
        }
    }
}
