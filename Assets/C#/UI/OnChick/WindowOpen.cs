using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowOpen : MonoBehaviour
{
    public GameObject window;
    public void open()
    {
       window.SetActive(true);
    }
}
