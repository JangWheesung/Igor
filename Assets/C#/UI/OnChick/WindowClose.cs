using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowClose : MonoBehaviour
{
    public GameObject window;
    public void close()
    {
        window.SetActive(false);
    }
}
