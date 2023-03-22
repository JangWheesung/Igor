using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetResolution : MonoBehaviour
{
    private void Start()
    {
        Screen.SetResolution(1920, (3 / 4) * 1920, true);
    }
}
